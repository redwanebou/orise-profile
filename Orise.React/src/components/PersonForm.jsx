import React from 'react';
import usePersonForm from '../hooks/usePersonForm';

const PersonForm = () => {
  const form = usePersonForm();

  return (
    <div className="form-wrapper">
      <h2>Person Profile</h2>
      <form onSubmit={form.handleSubmit}>
        <input value={form.firstName} onChange={e => form.setFirstName(e.target.value)} placeholder="First Name" required />
        <input value={form.lastName} onChange={e => form.setLastName(e.target.value)} placeholder="Last Name" required />

        <div>
          <input value={form.skillInput} onChange={e => form.setSkillInput(e.target.value)} placeholder="Social Skill" />
          <button type="button" onClick={form.addSkill}>+ Add Skill</button>
          <ul>
            {form.socialSkills.map((skill, idx) => <li key={idx}>{skill}</li>)}
          </ul>
        </div>

        <div>
          <input value={form.accountType} onChange={e => form.setAccountType(e.target.value)} placeholder="Account Type" />
          <input value={form.accountAddress} onChange={e => form.setAccountAddress(e.target.value)} placeholder="Account Address" />
          <button type="button" onClick={form.addAccount}>+ Add Account</button>
          <ul>
            {form.socialAccounts.map((acc, idx) => (
              <li key={idx}>{acc.type}: {acc.address}</li>
            ))}
          </ul>
        </div>

        <button type="submit" disabled={form.loading}>Submit</button>
      </form>

      {form.loading && <p>Verwerken...</p>}
      {form.error && <p className="error">{form.error}</p>}
      {form.response && (
        <div>
          <h3>Response</h3>
          <p>Vowels: {form.response.vowelCount}</p>
          <p>Consonants: {form.response.consonantCount}</p>
          <p>Reversed Name: {form.response.reversedName}</p>
          <pre>{JSON.stringify(form.response.person, null, 2)}</pre>
        </div>
      )}
    </div>
  );
};

export default PersonForm;