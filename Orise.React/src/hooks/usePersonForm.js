import { useState } from 'react';
import personService from '../services/personService';

const usePersonForm = () => {
  const [firstName, setFirstName] = useState('');
  const [lastName, setLastName] = useState('');
  const [socialSkills, setSocialSkills] = useState([]);
  const [skillInput, setSkillInput] = useState('');
  const [socialAccounts, setSocialAccounts] = useState([]);
  const [accountType, setAccountType] = useState('');
  const [accountAddress, setAccountAddress] = useState('');
  const [response, setResponse] = useState(null);
  const [error, setError] = useState(null);
  const [loading, setLoading] = useState(false);

  const addSkill = () => {
    if (skillInput.trim() && !socialSkills.includes(skillInput.trim())) {
      setSocialSkills([...socialSkills, skillInput.trim()]);
      setSkillInput('');
    }
  };

  const addAccount = () => {
    if (accountType && accountAddress) {
      setSocialAccounts([...socialAccounts, {
        type: accountType.trim(),
        address: accountAddress.trim()
      }]);
      setAccountType('');
      setAccountAddress('');
    }
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (skillInput.trim()) addSkill();
    if (accountType.trim() && accountAddress.trim()) addAccount();

    const data = { firstName, lastName, socialSkills, socialAccounts };

    try {
      setLoading(true);
      const res = await personService.submitPerson(data);
      setResponse(res);
      setError(null);
    } catch (err) {
      console.error(err);
      setError('Er ging iets mis bij het versturen.');
    } finally {
      setLoading(false);
    }
  };

  return {
    firstName, setFirstName,
    lastName, setLastName,
    socialSkills, skillInput, setSkillInput, addSkill,
    socialAccounts, accountType, setAccountType, accountAddress, setAccountAddress, addAccount,
    handleSubmit, response, error, loading
  };
};

export default usePersonForm;