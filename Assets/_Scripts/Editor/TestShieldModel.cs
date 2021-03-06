using NUnit.Framework;

public class TestShieldModel {

	[Test]
	public void TestStrengthOneHundred() {
	
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 100;

		//Act
		int result = sm.GetStrength();

		//Assert
		Assert.AreEqual(expectedResult, result);
	
	}

	[Test]
	public void TestRepairQuantity(){
		ShieldModel sm = new ShieldModel ();
		int expectedResult = 10;

		//Act
		int result = sm.RepairQuantity;

		//Assert
		Assert.AreEqual(expectedResult, result);

	}

	[Test]
	public void TestRepairThreshold(){

		ShieldModel sm = new ShieldModel ();
		int expectedResult = 25;

		//Act
		int result = sm.RepairableThreshold;

		//Assert
		Assert.AreEqual (expectedResult, result);

	}

	[Test]
	public void TestIsRepairTrue(){

		ShieldModel sm = new ShieldModel ();

		//Act
		bool result = sm.IsRepairable ();

		//Assert
		Assert.True (result);

	}

	[Test]
	public void TestAfterDamageOfOne(){

		ShieldModel sm = new ShieldModel ();
		int damage = 1;
		int expectedResult = 99;

		//Act
		bool damageSuccess = sm.TakeDamage (damage);
		int result = sm.GetStrength ();
		bool repairResult = sm.IsRepairable ();

		//Assert
		Assert.True (damageSuccess);
		Assert.True(repairResult);
		Assert.AreEqual (expectedResult, result);

	}

	[Test] 
	public void TestAfterDamageOfTen(){

		ShieldModel sm = new ShieldModel ();
		int damage = 10;
		int expectedResult = 90;

		//Act
		bool damageSuccess = sm.TakeDamage (damage);
		int result = sm.GetStrength ();
		bool repairResult = sm.IsRepairable ();

		//Assert
		Assert.True (damageSuccess);
		Assert.True(repairResult);
		Assert.AreEqual (expectedResult, result);

	}

	[Test]
	public void TestAfterDamageOfEighty(){

		ShieldModel sm = new ShieldModel ();
		int damage = 80;
		int expectedResult = 20;

		//Act
		bool damageSuccess = sm.TakeDamage (damage);
		int result = sm.GetStrength ();
		bool repairResult = sm.IsRepairable ();

		//Assert
		Assert.True(damageSuccess);
		Assert.False (repairResult);
		Assert.AreEqual (expectedResult, result);

	}

	[Test]
	public void TestAfterDamageOfNinety(){

		ShieldModel sm = new ShieldModel ();
		int damage = 90;
		int expectedResult = 10;

		//Act
		bool damageSuccess = sm.TakeDamage (damage);
		int result = sm.GetStrength ();
		bool repairResult = sm.IsRepairable ();

		//Assert
		Assert.True(damageSuccess);
		Assert.False (repairResult);
		Assert.AreEqual (expectedResult, result);

	}

	[Test]
	public void TestAfterDamageOfElevenAndTick(){

		ShieldModel sm = new ShieldModel ();
		int damage = 11;
		int expectedResult = 99;
		int numOfTicks = 1;

		//Act
		bool damageSuccess = sm.TakeDamage (damage);
		//bool tick = sm.Tick (numOfTicks);
		int result = sm.GetStrength ();

		//Assert
		Assert.True (damageSuccess);
		Assert.AreEqual (expectedResult, result);

	}

}
