const { convertFromCharacterEntityReference, convertToCharacterEntityReference } = require('../lib/character-entity-reference.js');

const text = '&quot;abcdef&quot;';
const text2 = '\\';

try {
    const result = convertFromCharacterEntityReference(text);
    const result2 = convertToCharacterEntityReference(text2, true);

    console.log(result);
    console.log(result2);
} catch (error) {
    console.log(error);
}
