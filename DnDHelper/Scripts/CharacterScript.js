function rollAbility(statId) {
    var roll1 =Math.floor(Math.random() * 6) + 1;
    var roll2 = Math.floor(Math.random() * 6) + 1;
    var result = roll1 + roll2 + 6;
    $('#'+statId).val(result);
}

function rollStats() {
    rollAbility('strength');
    rollAbility('dexterity');
    rollAbility('constitution');
    rollAbility('intelligence');
    rollAbility('wisdom');
    rollAbility('charisma');
}