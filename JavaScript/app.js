

const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('Question here ', (answer) => {  
  console.log(`Ouput here: ${answer}`);
  rl.close();
});

