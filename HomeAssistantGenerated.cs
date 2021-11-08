using System;
using System.Collections.Generic;

namespace NdGreenhouse
{
	public interface IEntities
	{
		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		InputBooleanEntities InputBoolean { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		PersonEntities Person { get; }

		ScriptEntities Script { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public class Entities : IEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public Entities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public ScriptEntities Script => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public class AutomationEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public AutomationEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntity CheckTemperatureOfDb1Reservoir => new(_haContext, "automation.check_temperature_of_db1_reservoir");
		public AutomationEntity Db1WateringPump => new(_haContext, "automation.db1_watering_pump");
		public AutomationEntity Db2WateringPump => new(_haContext, "automation.db2_watering_pump");
		public AutomationEntity Db3WateringPump => new(_haContext, "automation.db3_watering_pump");
		public AutomationEntity Db3WateringPump2 => new(_haContext, "automation.db3_watering_pump_2");
		public AutomationEntity Db4WateringPump => new(_haContext, "automation.db4_watering_pump");
		public AutomationEntity Db6WateringPump => new(_haContext, "automation.db6_watering_pump");
		public AutomationEntity HeaterTry2 => new(_haContext, "automation.heater_try_2");
		public AutomationEntity OctoprintNotification => new(_haContext, "automation.octoprint_notification");
		public AutomationEntity Test => new(_haContext, "automation.test");
		public AutomationEntity TurnOffGrowLight => new(_haContext, "automation.turn_off_grow_light");
		public AutomationEntity TurnOffGrowLightInTheMornining => new(_haContext, "automation.turn_off_grow_light_in_the_mornining");
		public AutomationEntity TurnOnCirculatingFanEver4Hours => new(_haContext, "automation.turn_on_circulating_fan_ever_4_hours");
		public AutomationEntity TurnOnDb2PumpEvery4Hours => new(_haContext, "automation.turn_on_db2_pump_every_4_hours");
		public AutomationEntity TurnOnGrowLight => new(_haContext, "automation.turn_on_grow_light");
		public AutomationEntity TurnOnGrowLight42 => new(_haContext, "automation.turn_on_grow_light_4_2");
		public AutomationEntity TurnOnGrowLightDb1And2BeforeSunset => new(_haContext, "automation.turn_on_grow_light_db1_and_2_before_sunset");
		public AutomationEntity TurnOnNftPump => new(_haContext, "automation.turn_on_nft_pump");
		public AutomationEntity WriteStepperValueToEsp => new(_haContext, "automation.write_stepper_value_to_esp");
	}

	public class BinarySensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public BinarySensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public BinarySensorEntity AutoOffForWaterFiller => new(_haContext, "binary_sensor.auto_off_for_water_filler");
		public BinarySensorEntity BackBushesStationRunning => new(_haContext, "binary_sensor.back_bushes_station_running");
		public BinarySensorEntity BackLightStatus => new(_haContext, "binary_sensor.back_light_status");
		public BinarySensorEntity BerriesStationRunning => new(_haContext, "binary_sensor.berries_station_running");
		public BinarySensorEntity BucketEmpty => new(_haContext, "binary_sensor.bucket_empty");
		public BinarySensorEntity BucketFull => new(_haContext, "binary_sensor.bucket_full");
		public BinarySensorEntity BucketMedium => new(_haContext, "binary_sensor.bucket_medium");
		public BinarySensorEntity Db1WaterLevelState => new(_haContext, "binary_sensor.db_1_water_level_state");
		public BinarySensorEntity Db2WaterLevelState => new(_haContext, "binary_sensor.db_2_water_level_state");
		public BinarySensorEntity Db3WaterLevelState => new(_haContext, "binary_sensor.db_3_water_level_state");
		public BinarySensorEntity Db4WaterLevelState => new(_haContext, "binary_sensor.db_4_water_level_state");
		public BinarySensorEntity Db5WaterLevelState => new(_haContext, "binary_sensor.db_5_water_level_state");
		public BinarySensorEntity Db6WaterLevelState => new(_haContext, "binary_sensor.db_6_water_level_state");
		public BinarySensorEntity Db2Empty => new(_haContext, "binary_sensor.db2_empty");
		public BinarySensorEntity Db2Full => new(_haContext, "binary_sensor.db2_full");
		public BinarySensorEntity Db2Medium => new(_haContext, "binary_sensor.db2_medium");
		public BinarySensorEntity Db3BucketEmpty => new(_haContext, "binary_sensor.db3_bucket_empty");
		public BinarySensorEntity Db3BucketFull => new(_haContext, "binary_sensor.db3_bucket_full");
		public BinarySensorEntity Db3BucketMedium => new(_haContext, "binary_sensor.db3_bucket_medium");
		public BinarySensorEntity Db4BucketEmpty => new(_haContext, "binary_sensor.db4_bucket_empty");
		public BinarySensorEntity Db4BucketFull => new(_haContext, "binary_sensor.db4_bucket_full");
		public BinarySensorEntity Db4BucketMedium => new(_haContext, "binary_sensor.db4_bucket_medium");
		public BinarySensorEntity Db5BucketEmpty => new(_haContext, "binary_sensor.db5_bucket_empty");
		public BinarySensorEntity Db5BucketFull => new(_haContext, "binary_sensor.db5_bucket_full");
		public BinarySensorEntity Db5BucketMedium => new(_haContext, "binary_sensor.db5_bucket_medium");
		public BinarySensorEntity Db6BucketEmpty => new(_haContext, "binary_sensor.db6_bucket_empty");
		public BinarySensorEntity Db6BucketFull => new(_haContext, "binary_sensor.db6_bucket_full");
		public BinarySensorEntity Db6BucketMedium => new(_haContext, "binary_sensor.db6_bucket_medium");
		public BinarySensorEntity Espcam01Button => new(_haContext, "binary_sensor.espcam01_button");
		public BinarySensorEntity Espcam01Pir => new(_haContext, "binary_sensor.espcam01_pir");
		public BinarySensorEntity FanButton => new(_haContext, "binary_sensor.fan_button");
		public BinarySensorEntity FanStatus => new(_haContext, "binary_sensor.fan_status");
		public BinarySensorEntity FirstHalfProgramRunning => new(_haContext, "binary_sensor.first_half_program_running");
		public BinarySensorEntity FreshResWaterLevelState => new(_haContext, "binary_sensor.fresh_res_water_level_state");
		public BinarySensorEntity FreshWaterBucketEmpty => new(_haContext, "binary_sensor.fresh_water_bucket_empty");
		public BinarySensorEntity FreshWaterBucketFull => new(_haContext, "binary_sensor.fresh_water_bucket_full");
		public BinarySensorEntity FreshWaterBucketMedium => new(_haContext, "binary_sensor.fresh_water_bucket_medium");
		public BinarySensorEntity FreshWaterEmpty => new(_haContext, "binary_sensor.fresh_water_empty");
		public BinarySensorEntity FreshWaterFull => new(_haContext, "binary_sensor.fresh_water_full");
		public BinarySensorEntity FreshWaterLevelState => new(_haContext, "binary_sensor.fresh_water_level_state");
		public BinarySensorEntity FreshWaterMedium => new(_haContext, "binary_sensor.fresh_water_medium");
		public BinarySensorEntity FrontFieldStationRunning => new(_haContext, "binary_sensor.front_field_station_running");
		public BinarySensorEntity FrontFlowerSprinklerStationRunning => new(_haContext, "binary_sensor.front_flower_sprinkler_station_running");
		public BinarySensorEntity FrontLightButton => new(_haContext, "binary_sensor.front_light_button");
		public BinarySensorEntity FrontLightStatus => new(_haContext, "binary_sensor.front_light_status");
		public BinarySensorEntity FruitTreesStationRunning => new(_haContext, "binary_sensor.fruit_trees_station_running");
		public BinarySensorEntity GhBackLightState => new(_haContext, "binary_sensor.gh_back_light_state");
		public BinarySensorEntity GreenHouseMain => new(_haContext, "binary_sensor.green_house_main");
		public BinarySensorEntity GreenHousePowerStatus => new(_haContext, "binary_sensor.green_house_power_status");
		public BinarySensorEntity HomeAssistantBeansStationRunning => new(_haContext, "binary_sensor.home_assistant_beans_station_running");
		public BinarySensorEntity MotoGStylusIsCharging => new(_haContext, "binary_sensor.moto_g_stylus_is_charging");
		public BinarySensorEntity NatureSprinklerStationRunning => new(_haContext, "binary_sensor.nature_sprinkler_station_running");
		public BinarySensorEntity NftResEmpty => new(_haContext, "binary_sensor.nft_res_empty");
		public BinarySensorEntity NftResEmpty2 => new(_haContext, "binary_sensor.nft_res_empty_2");
		public BinarySensorEntity NftResFull => new(_haContext, "binary_sensor.nft_res_full");
		public BinarySensorEntity NftResFull2 => new(_haContext, "binary_sensor.nft_res_full_2");
		public BinarySensorEntity NftResMedium => new(_haContext, "binary_sensor.nft_res_medium");
		public BinarySensorEntity NftResMedium2 => new(_haContext, "binary_sensor.nft_res_medium_2");
		public BinarySensorEntity NftWaterLevelStatus => new(_haContext, "binary_sensor.nft_water_level_status");
		public BinarySensorEntity NftWaterLevelStatus2 => new(_haContext, "binary_sensor.nft_water_level_status_2");
		public BinarySensorEntity OctoprintPrinting => new(_haContext, "binary_sensor.octoprint_printing");
		public BinarySensorEntity OctoprintPrintingError => new(_haContext, "binary_sensor.octoprint_printing_error");
		public BinarySensorEntity OpenSprinklerRainDelayActive => new(_haContext, "binary_sensor.open_sprinkler_rain_delay_active");
		public BinarySensorEntity OpenSprinklerSensor1Active => new(_haContext, "binary_sensor.open_sprinkler_sensor_1_active");
		public BinarySensorEntity OpenSprinklerSensor2Active => new(_haContext, "binary_sensor.open_sprinkler_sensor_2_active");
		public BinarySensorEntity PowerStrip1Button => new(_haContext, "binary_sensor.power_strip_1_button");
		public BinarySensorEntity PowerStrip1ServerStatus => new(_haContext, "binary_sensor.power_strip_1_server_status");
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		public BinarySensorEntity S07StationRunning => new(_haContext, "binary_sensor.s07_station_running");
		public BinarySensorEntity S08StationRunning => new(_haContext, "binary_sensor.s08_station_running");
		public BinarySensorEntity S14StationRunning => new(_haContext, "binary_sensor.s14_station_running");
		public BinarySensorEntity S15StationRunning => new(_haContext, "binary_sensor.s15_station_running");
		public BinarySensorEntity S16StationRunning => new(_haContext, "binary_sensor.s16_station_running");
		public BinarySensorEntity S17StationRunning => new(_haContext, "binary_sensor.s17_station_running");
		public BinarySensorEntity S18StationRunning => new(_haContext, "binary_sensor.s18_station_running");
		public BinarySensorEntity S19StationRunning => new(_haContext, "binary_sensor.s19_station_running");
		public BinarySensorEntity S20StationRunning => new(_haContext, "binary_sensor.s20_station_running");
		public BinarySensorEntity S21StationRunning => new(_haContext, "binary_sensor.s21_station_running");
		public BinarySensorEntity S22StationRunning => new(_haContext, "binary_sensor.s22_station_running");
		public BinarySensorEntity S23StationRunning => new(_haContext, "binary_sensor.s23_station_running");
		public BinarySensorEntity S24StationRunning => new(_haContext, "binary_sensor.s24_station_running");
		public BinarySensorEntity SamsungflexIsCharging => new(_haContext, "binary_sensor.samsungflex_is_charging");
		public BinarySensorEntity SecondHalfProgramRunning => new(_haContext, "binary_sensor.second_half_program_running");
		public BinarySensorEntity SideBackGrassStationRunning => new(_haContext, "binary_sensor.side_back_grass_station_running");
		public BinarySensorEntity SnapPeasAndSunflowersStationRunning => new(_haContext, "binary_sensor.snap_peas_and_sunflowers_station_running");
		public BinarySensorEntity Station1Status => new(_haContext, "binary_sensor.station_1_status");
		public BinarySensorEntity Station2Status => new(_haContext, "binary_sensor.station_2_status");
		public BinarySensorEntity Station3Status => new(_haContext, "binary_sensor.station_3_status");
		public BinarySensorEntity Station4Status => new(_haContext, "binary_sensor.station_4_status");
		public BinarySensorEntity Station4Status2 => new(_haContext, "binary_sensor.station_4_status_2");
		public BinarySensorEntity SwpCoolWaterLevelStatus => new(_haContext, "binary_sensor.swp_cool_water_level_status");
		public BinarySensorEntity SwpResEmpty => new(_haContext, "binary_sensor.swp_res_empty");
		public BinarySensorEntity SwpResFull => new(_haContext, "binary_sensor.swp_res_full");
		public BinarySensorEntity SwpResMedium => new(_haContext, "binary_sensor.swp_res_medium");
		public BinarySensorEntity TestZoneResWaterLevelState => new(_haContext, "binary_sensor.test_zone_res_water_level_state");
		public BinarySensorEntity TestZoneWaterBucketEmpty => new(_haContext, "binary_sensor.test_zone_water_bucket_empty");
		public BinarySensorEntity TestZoneWaterBucketFull => new(_haContext, "binary_sensor.test_zone_water_bucket_full");
		public BinarySensorEntity TestZoneWaterBucketMedium => new(_haContext, "binary_sensor.test_zone_water_bucket_medium");
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
		public BinarySensorEntity Valve2Closed => new(_haContext, "binary_sensor.valve_2_closed");
		public BinarySensorEntity Valve2Open => new(_haContext, "binary_sensor.valve_2_open");
		public BinarySensorEntity ValveClosed => new(_haContext, "binary_sensor.valve_closed");
		public BinarySensorEntity ValveOpen => new(_haContext, "binary_sensor.valve_open");
		public BinarySensorEntity WellPTsAndAAStationRunning => new(_haContext, "binary_sensor.well_p_ts_and_a_a_station_running");
		public BinarySensorEntity WonderStrawberriesStationRunning => new(_haContext, "binary_sensor.wonder_strawberries_station_running");
	}

	public class CameraEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CameraEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public CameraEntity Espcam01 => new(_haContext, "camera.espcam01");
		public CameraEntity Octoprint => new(_haContext, "camera.octoprint");
	}

	public class ClimateEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ClimateEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public ClimateEntity Home => new(_haContext, "climate.home");
	}

	public class DeviceTrackerEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public DeviceTrackerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public DeviceTrackerEntity MotoGStylus => new(_haContext, "device_tracker.moto_g_stylus");
		public DeviceTrackerEntity Samsungflex => new(_haContext, "device_tracker.samsungflex");
	}

	public class InputBooleanEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputBooleanEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public InputBooleanEntity TestingTankHold => new(_haContext, "input_boolean.testing_tank_hold");
	}

	public class InputNumberEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputNumberEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public InputNumberEntity Nutrientunitstoadd => new(_haContext, "input_number.nutrientunitstoadd");
	}

	public class InputSelectEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputSelectEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public InputSelectEntity ReservoirRes => new(_haContext, "input_select.reservoir_res");
	}

	public class PersonEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersonEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public PersonEntity NickGelotte => new(_haContext, "person.nick_gelotte");
	}

	public class ScriptEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ScriptEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public ScriptEntity AddDoseToCurrentZone => new(_haContext, "script.add_dose_to_current_zone");
		public ScriptEntity MovePump1 => new(_haContext, "script.move_pump_1");
		public ScriptEntity MovePump2 => new(_haContext, "script.move_pump_2");
		public ScriptEntity MovePump3 => new(_haContext, "script.move_pump_3");
		public ScriptEntity RefillCurrentBucket => new(_haContext, "script.refill_current_bucket");
		public ScriptEntity RefillFreshWaterTank => new(_haContext, "script.refill_fresh_water_tank");
		public ScriptEntity RefillSwpCooler => new(_haContext, "script.refill_swp_cooler");
	}

	public class SensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public SensorEntity BackBushesStationStatus => new(_haContext, "sensor.back_bushes_station_status");
		public SensorEntity BerriesStationStatus => new(_haContext, "sensor.berries_station_status");
		public SensorEntity BleBatteryA4c13818a9e5 => new(_haContext, "sensor.ble_battery_a4c13818a9e5");
		public SensorEntity BleBatteryGhIndoorTemp => new(_haContext, "sensor.ble_battery_gh_indoor_temp");
		public SensorEntity BleBatteryGhTempExternal => new(_haContext, "sensor.ble_battery_gh_temp_external");
		public SensorEntity BleHumidityA4c13818a9e5 => new(_haContext, "sensor.ble_humidity_a4c13818a9e5");
		public SensorEntity BleHumidityGhExternal => new(_haContext, "sensor.ble_humidity_gh_external");
		public SensorEntity BleHumidityGhIndoorTemp => new(_haContext, "sensor.ble_humidity_gh_indoor_temp");
		public SensorEntity BleHumidityOutdoorA4c13818a9e5 => new(_haContext, "sensor.ble_humidity_outdoor_a4c13818a9e5");
		public SensorEntity BleTemperatureA4c13818a9e5 => new(_haContext, "sensor.ble_temperature_a4c13818a9e5");
		public SensorEntity BleTemperatureGhIndoorTemp => new(_haContext, "sensor.ble_temperature_gh_indoor_temp");
		public SensorEntity BleTemperatureGhTempExternal => new(_haContext, "sensor.ble_temperature_gh_temp_external");
		public SensorEntity BleTemperatureOutdoorA4c13818a9e5 => new(_haContext, "sensor.ble_temperature_outdoor_a4c13818a9e5");
		public SensorEntity BleVoltageGhIndoorTemp => new(_haContext, "sensor.ble_voltage_gh_indoor_temp");
		public SensorEntity BleVoltageGhTempExternal => new(_haContext, "sensor.ble_voltage_gh_temp_external");
		public SensorEntity DailyEnergy => new(_haContext, "sensor.daily_energy");
		public SensorEntity Db1Ec => new(_haContext, "sensor.db1_ec");
		public SensorEntity Db1Temp => new(_haContext, "sensor.db1_temp");
		public SensorEntity Db2Ec => new(_haContext, "sensor.db2_ec");
		public SensorEntity Db2Temp => new(_haContext, "sensor.db2_temp");
		public SensorEntity Db3Ec => new(_haContext, "sensor.db3_ec");
		public SensorEntity Db3Temp => new(_haContext, "sensor.db3_temp");
		public SensorEntity Db4Ec => new(_haContext, "sensor.db4_ec");
		public SensorEntity Db4Temp => new(_haContext, "sensor.db4_temp");
		public SensorEntity Db5Ec => new(_haContext, "sensor.db5_ec");
		public SensorEntity Db5Temp => new(_haContext, "sensor.db5_temp");
		public SensorEntity Db6Ec => new(_haContext, "sensor.db6_ec");
		public SensorEntity Db6Temp => new(_haContext, "sensor.db6_temp");
		public SensorEntity EcSensor => new(_haContext, "sensor.ec_sensor");
		public SensorEntity ExteriorHumidity => new(_haContext, "sensor.exterior_humidity");
		public SensorEntity ExteriorTemperature => new(_haContext, "sensor.exterior_temperature");
		public SensorEntity FrontFieldStationStatus => new(_haContext, "sensor.front_field_station_status");
		public SensorEntity FrontFlowerSprinklerStationStatus => new(_haContext, "sensor.front_flower_sprinkler_station_status");
		public SensorEntity FruitTreesStationStatus => new(_haContext, "sensor.fruit_trees_station_status");
		public SensorEntity GhInteralProtectedHumidity => new(_haContext, "sensor.gh_interal_protected_humidity");
		public SensorEntity GhInteralProtectedTemp => new(_haContext, "sensor.gh_interal_protected_temp");
		public SensorEntity GhPowerR2Current => new(_haContext, "sensor.gh_power_r2_current");
		public SensorEntity GhPowerR2Power => new(_haContext, "sensor.gh_power_r2_power");
		public SensorEntity GhPowerR2Voltage => new(_haContext, "sensor.gh_power_r2_voltage");
		public SensorEntity GreenhosueCo2Temp => new(_haContext, "sensor.greenhosue_co2_temp");
		public SensorEntity GreenhouseCo2 => new(_haContext, "sensor.greenhouse_co2");
		public SensorEntity GreenhouseCo2Hum => new(_haContext, "sensor.greenhouse_co2_hum");
		public SensorEntity GreenhouseHumidity => new(_haContext, "sensor.greenhouse_humidity");
		public SensorEntity GreenhouseInternalHumidity => new(_haContext, "sensor.greenhouse_internal_humidity");
		public SensorEntity GreenhouseInternalTemperature => new(_haContext, "sensor.greenhouse_internal_temperature");
		public SensorEntity GreenhouseTemp => new(_haContext, "sensor.greenhouse_temp");
		public SensorEntity Hacs => new(_haContext, "sensor.hacs");
		public SensorEntity HomeAssistantBeansStationStatus => new(_haContext, "sensor.home_assistant_beans_station_status");
		public SensorEntity IndoorTemperature => new(_haContext, "sensor.indoor_temperature");
		public SensorEntity LocalIp => new(_haContext, "sensor.local_ip");
		public SensorEntity MonthlyEnergy => new(_haContext, "sensor.monthly_energy");
		public SensorEntity MotoGStylusAudioSensor => new(_haContext, "sensor.moto_g_stylus_audio_sensor");
		public SensorEntity MotoGStylusBatteryHealth => new(_haContext, "sensor.moto_g_stylus_battery_health");
		public SensorEntity MotoGStylusBatteryLevel => new(_haContext, "sensor.moto_g_stylus_battery_level");
		public SensorEntity MotoGStylusBatteryState => new(_haContext, "sensor.moto_g_stylus_battery_state");
		public SensorEntity MotoGStylusBatteryTemperature => new(_haContext, "sensor.moto_g_stylus_battery_temperature");
		public SensorEntity MotoGStylusBluetoothConnection => new(_haContext, "sensor.moto_g_stylus_bluetooth_connection");
		public SensorEntity MotoGStylusChargerType => new(_haContext, "sensor.moto_g_stylus_charger_type");
		public SensorEntity MotoGStylusDoNotDisturbSensor => new(_haContext, "sensor.moto_g_stylus_do_not_disturb_sensor");
		public SensorEntity MotoGStylusGeocodedLocation => new(_haContext, "sensor.moto_g_stylus_geocoded_location");
		public SensorEntity MotoGStylusLastReboot => new(_haContext, "sensor.moto_g_stylus_last_reboot");
		public SensorEntity MotoGStylusLightSensor => new(_haContext, "sensor.moto_g_stylus_light_sensor");
		public SensorEntity MotoGStylusNextAlarm => new(_haContext, "sensor.moto_g_stylus_next_alarm");
		public SensorEntity MotoGStylusProximitySensor => new(_haContext, "sensor.moto_g_stylus_proximity_sensor");
		public SensorEntity MotoGStylusStorageSensor => new(_haContext, "sensor.moto_g_stylus_storage_sensor");
		public SensorEntity MotoGStylusWifiConnection => new(_haContext, "sensor.moto_g_stylus_wifi_connection");
		public SensorEntity NatureSprinklerStationStatus => new(_haContext, "sensor.nature_sprinkler_station_status");
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		public SensorEntity NftEc => new(_haContext, "sensor.nft_ec");
		public SensorEntity NftTemp => new(_haContext, "sensor.nft_temp");
		public SensorEntity NftWaterLevelState => new(_haContext, "sensor.nft_water_level_state");
		public SensorEntity NftWaterLevelState2 => new(_haContext, "sensor.nft_water_level_state_2");
		public SensorEntity OctoprintCurrentState => new(_haContext, "sensor.octoprint_current_state");
		public SensorEntity OctoprintEstimatedFinishTime => new(_haContext, "sensor.octoprint_estimated_finish_time");
		public SensorEntity OctoprintJobPercentage => new(_haContext, "sensor.octoprint_job_percentage");
		public SensorEntity OctoprintStartTime => new(_haContext, "sensor.octoprint_start_time");
		public SensorEntity OpenSprinklerFlowRate => new(_haContext, "sensor.open_sprinkler_flow_rate");
		public SensorEntity OpenSprinklerLastRun => new(_haContext, "sensor.open_sprinkler_last_run");
		public SensorEntity OpenSprinklerRainDelayStopTime => new(_haContext, "sensor.open_sprinkler_rain_delay_stop_time");
		public SensorEntity OpenSprinklerWaterLevel => new(_haContext, "sensor.open_sprinkler_water_level");
		public SensorEntity OpenweathermapCloudCoverage => new(_haContext, "sensor.openweathermap_cloud_coverage");
		public SensorEntity OpenweathermapCondition => new(_haContext, "sensor.openweathermap_condition");
		public SensorEntity OpenweathermapDewPoint => new(_haContext, "sensor.openweathermap_dew_point");
		public SensorEntity OpenweathermapFeelsLikeTemperature => new(_haContext, "sensor.openweathermap_feels_like_temperature");
		public SensorEntity OpenweathermapForecastCloudCoverage => new(_haContext, "sensor.openweathermap_forecast_cloud_coverage");
		public SensorEntity OpenweathermapForecastCondition => new(_haContext, "sensor.openweathermap_forecast_condition");
		public SensorEntity OpenweathermapForecastPrecipitation => new(_haContext, "sensor.openweathermap_forecast_precipitation");
		public SensorEntity OpenweathermapForecastPrecipitationProbability => new(_haContext, "sensor.openweathermap_forecast_precipitation_probability");
		public SensorEntity OpenweathermapForecastPressure => new(_haContext, "sensor.openweathermap_forecast_pressure");
		public SensorEntity OpenweathermapForecastTemperature => new(_haContext, "sensor.openweathermap_forecast_temperature");
		public SensorEntity OpenweathermapForecastTemperatureLow => new(_haContext, "sensor.openweathermap_forecast_temperature_low");
		public SensorEntity OpenweathermapForecastTime => new(_haContext, "sensor.openweathermap_forecast_time");
		public SensorEntity OpenweathermapForecastWindBearing => new(_haContext, "sensor.openweathermap_forecast_wind_bearing");
		public SensorEntity OpenweathermapForecastWindSpeed => new(_haContext, "sensor.openweathermap_forecast_wind_speed");
		public SensorEntity OpenweathermapHumidity => new(_haContext, "sensor.openweathermap_humidity");
		public SensorEntity OpenweathermapPrecipitationKind => new(_haContext, "sensor.openweathermap_precipitation_kind");
		public SensorEntity OpenweathermapPressure => new(_haContext, "sensor.openweathermap_pressure");
		public SensorEntity OpenweathermapRain => new(_haContext, "sensor.openweathermap_rain");
		public SensorEntity OpenweathermapSnow => new(_haContext, "sensor.openweathermap_snow");
		public SensorEntity OpenweathermapTemperature => new(_haContext, "sensor.openweathermap_temperature");
		public SensorEntity OpenweathermapUvIndex => new(_haContext, "sensor.openweathermap_uv_index");
		public SensorEntity OpenweathermapWeather => new(_haContext, "sensor.openweathermap_weather");
		public SensorEntity OpenweathermapWeatherCode => new(_haContext, "sensor.openweathermap_weather_code");
		public SensorEntity OpenweathermapWindBearing => new(_haContext, "sensor.openweathermap_wind_bearing");
		public SensorEntity OpenweathermapWindSpeed => new(_haContext, "sensor.openweathermap_wind_speed");
		public SensorEntity OutdoorTemperature => new(_haContext, "sensor.outdoor_temperature");
		public SensorEntity PowerStrip1WifiStatus => new(_haContext, "sensor.power_strip_1_wifi_status");
		public SensorEntity PowerStrip1WifiStatus2 => new(_haContext, "sensor.power_strip_1_wifi_status_2");
		public SensorEntity PowerStripMidWifiStatus => new(_haContext, "sensor.power_strip_mid_wifi_status");
		public SensorEntity PowerStripTestZoneWifiStatus => new(_haContext, "sensor.power_strip_test_zone_wifi_status");
		public SensorEntity S07StationStatus => new(_haContext, "sensor.s07_station_status");
		public SensorEntity S08StationStatus => new(_haContext, "sensor.s08_station_status");
		public SensorEntity S14StationStatus => new(_haContext, "sensor.s14_station_status");
		public SensorEntity S15StationStatus => new(_haContext, "sensor.s15_station_status");
		public SensorEntity S16StationStatus => new(_haContext, "sensor.s16_station_status");
		public SensorEntity S17StationStatus => new(_haContext, "sensor.s17_station_status");
		public SensorEntity S18StationStatus => new(_haContext, "sensor.s18_station_status");
		public SensorEntity S19StationStatus => new(_haContext, "sensor.s19_station_status");
		public SensorEntity S20StationStatus => new(_haContext, "sensor.s20_station_status");
		public SensorEntity S21StationStatus => new(_haContext, "sensor.s21_station_status");
		public SensorEntity S22StationStatus => new(_haContext, "sensor.s22_station_status");
		public SensorEntity S23StationStatus => new(_haContext, "sensor.s23_station_status");
		public SensorEntity S24StationStatus => new(_haContext, "sensor.s24_station_status");
		public SensorEntity SamsungflexBatteryHealth => new(_haContext, "sensor.samsungflex_battery_health");
		public SensorEntity SamsungflexBatteryLevel => new(_haContext, "sensor.samsungflex_battery_level");
		public SensorEntity SamsungflexBatteryState => new(_haContext, "sensor.samsungflex_battery_state");
		public SensorEntity SamsungflexBatteryTemperature => new(_haContext, "sensor.samsungflex_battery_temperature");
		public SensorEntity SamsungflexChargerType => new(_haContext, "sensor.samsungflex_charger_type");
		public SensorEntity SideBackGrassStationStatus => new(_haContext, "sensor.side_back_grass_station_status");
		public SensorEntity SnapPeasAndSunflowersStationStatus => new(_haContext, "sensor.snap_peas_and_sunflowers_station_status");
		public SensorEntity SonoffPowUptime => new(_haContext, "sensor.sonoff_pow_uptime");
		public SensorEntity SonoffPowWifiSignal => new(_haContext, "sensor.sonoff_pow_wifi_signal");
		public SensorEntity SwpCoolWaterLevelState => new(_haContext, "sensor.swp_cool_water_level_state");
		public SensorEntity WaterTemperature => new(_haContext, "sensor.water_temperature");
		public SensorEntity WellPTsAndAAStationStatus => new(_haContext, "sensor.well_p_ts_and_a_a_station_status");
		public SensorEntity WonderStrawberriesStationStatus => new(_haContext, "sensor.wonder_strawberries_station_status");
	}

	public class SunEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SunEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public SwitchEntity BackBushesStationEnabled => new(_haContext, "switch.back_bushes_station_enabled");
		public SwitchEntity BerriesStationEnabled => new(_haContext, "switch.berries_station_enabled");
		public SwitchEntity Enablepumps => new(_haContext, "switch.enablepumps");
		public SwitchEntity Fan => new(_haContext, "switch.fan");
		public SwitchEntity FirstHalfProgramEnabled => new(_haContext, "switch.first_half_program_enabled");
		public SwitchEntity FrontFieldStationEnabled => new(_haContext, "switch.front_field_station_enabled");
		public SwitchEntity FrontFlowerSprinklerStationEnabled => new(_haContext, "switch.front_flower_sprinkler_station_enabled");
		public SwitchEntity FruitTreesStationEnabled => new(_haContext, "switch.fruit_trees_station_enabled");
		public SwitchEntity GhBackLight => new(_haContext, "switch.gh_back_light");
		public SwitchEntity GhFrontLightSwitch => new(_haContext, "switch.gh_front_light_switch");
		public SwitchEntity GhInteriorAndExteriorTempRestart => new(_haContext, "switch.gh_interior_and_exterior_temp_restart");
		public SwitchEntity GhProtectedRestart => new(_haContext, "switch.gh_protected_restart");
		public SwitchEntity GreenHousePower => new(_haContext, "switch.green_house_power");
		public SwitchEntity HomeAssistantBeansStationEnabled => new(_haContext, "switch.home_assistant_beans_station_enabled");
		public SwitchEntity NatureSprinklerStationEnabled => new(_haContext, "switch.nature_sprinkler_station_enabled");
		public SwitchEntity NetdaemonDehumidifierApp => new(_haContext, "switch.netdaemon_dehumidifier_app");
		public SwitchEntity NetdaemonEnvcontrolsApp => new(_haContext, "switch.netdaemon_envcontrols_app");
		public SwitchEntity NetdaemonGrowlightApp => new(_haContext, "switch.netdaemon_growlight_app");
		public SwitchEntity NetdaemonHelloworldapp => new(_haContext, "switch.netdaemon_helloworldapp");
		public SwitchEntity NetdaemonNetdaemonApp => new(_haContext, "switch.netdaemon_netdaemon_app");
		public SwitchEntity NetdaemonNutrientsApp => new(_haContext, "switch.netdaemon_nutrients_app");
		public SwitchEntity NetdaemonPirlightsApp => new(_haContext, "switch.netdaemon_pirlights_app");
		public SwitchEntity NetdaemonRefillApp => new(_haContext, "switch.netdaemon_refill_app");
		public SwitchEntity NetdaemonRefillapp => new(_haContext, "switch.netdaemon_refillapp");
		public SwitchEntity OpenSprinklerEnabled => new(_haContext, "switch.open_sprinkler_enabled");
		public SwitchEntity PowerStrip1Outlet1 => new(_haContext, "switch.power_strip_1_outlet_1");
		public SwitchEntity PowerStrip1Outlet12 => new(_haContext, "switch.power_strip_1_outlet_1_2");
		public SwitchEntity PowerStrip1Outlet2 => new(_haContext, "switch.power_strip_1_outlet_2");
		public SwitchEntity PowerStrip1Outlet22 => new(_haContext, "switch.power_strip_1_outlet_2_2");
		public SwitchEntity PowerStrip1Outlet3 => new(_haContext, "switch.power_strip_1_outlet_3");
		public SwitchEntity PowerStrip1Outlet32 => new(_haContext, "switch.power_strip_1_outlet_3_2");
		public SwitchEntity PowerStrip1Outlet4 => new(_haContext, "switch.power_strip_1_outlet_4");
		public SwitchEntity PowerStrip1Outlet42 => new(_haContext, "switch.power_strip_1_outlet_4_2");
		public SwitchEntity PowerStrip1Usb => new(_haContext, "switch.power_strip_1_usb");
		public SwitchEntity PowerStrip1Usb2 => new(_haContext, "switch.power_strip_1_usb_2");
		public SwitchEntity PowerStripMidOutlet1 => new(_haContext, "switch.power_strip_mid_outlet_1");
		public SwitchEntity PowerStripMidOutlet2 => new(_haContext, "switch.power_strip_mid_outlet_2");
		public SwitchEntity PowerStripMidOutlet3 => new(_haContext, "switch.power_strip_mid_outlet_3");
		public SwitchEntity PowerStripMidOutlet4 => new(_haContext, "switch.power_strip_mid_outlet_4");
		public SwitchEntity PowerStripMidUsb => new(_haContext, "switch.power_strip_mid_usb");
		public SwitchEntity PowerStripNeOutlet1 => new(_haContext, "switch.power_strip_ne_outlet_1");
		public SwitchEntity PowerStripNeOutlet2 => new(_haContext, "switch.power_strip_ne_outlet_2");
		public SwitchEntity PowerStripNeOutlet3 => new(_haContext, "switch.power_strip_ne_outlet_3");
		public SwitchEntity PowerStripNeOutlet4 => new(_haContext, "switch.power_strip_ne_outlet_4");
		public SwitchEntity PowerStripNeUsb => new(_haContext, "switch.power_strip_ne_usb");
		public SwitchEntity PowerStripTestZoneOutlet1 => new(_haContext, "switch.power_strip_test_zone_outlet_1");
		public SwitchEntity PowerStripTestZoneOutlet2 => new(_haContext, "switch.power_strip_test_zone_outlet_2");
		public SwitchEntity PowerStripTestZoneOutlet3 => new(_haContext, "switch.power_strip_test_zone_outlet_3");
		public SwitchEntity PowerStripTestZoneOutlet4 => new(_haContext, "switch.power_strip_test_zone_outlet_4");
		public SwitchEntity PowerStripTestZoneUsb => new(_haContext, "switch.power_strip_test_zone_usb");
		public SwitchEntity RestartDb1WaterLevel => new(_haContext, "switch.restart_db1_water_level");
		public SwitchEntity RestartDb2WaterLevel => new(_haContext, "switch.restart_db2_water_level");
		public SwitchEntity RestartDb3WaterLevel => new(_haContext, "switch.restart_db3_water_level");
		public SwitchEntity RestartDb4WaterLevel => new(_haContext, "switch.restart_db4_water_level");
		public SwitchEntity RestartDb5WaterLevel => new(_haContext, "switch.restart_db5_water_level");
		public SwitchEntity RestartDb6WaterLevel => new(_haContext, "switch.restart_db6_water_level");
		public SwitchEntity RestartEcSensor => new(_haContext, "switch.restart_ec_sensor");
		public SwitchEntity RestartFreshResWaterLevel => new(_haContext, "switch.restart_fresh_res_water_level");
		public SwitchEntity RestartFreshWaterLevel => new(_haContext, "switch.restart_fresh_water_level");
		public SwitchEntity RestartNftWaterLevel => new(_haContext, "switch.restart_nft_water_level");
		public SwitchEntity RestartNftWaterLevel2 => new(_haContext, "switch.restart_nft_water_level_2");
		public SwitchEntity RestartSwpCoolWaterLevel => new(_haContext, "switch.restart_swp_cool_water_level");
		public SwitchEntity RestartTestZoneWaterLevel => new(_haContext, "switch.restart_test_zone_water_level");
		public SwitchEntity S07StationEnabled => new(_haContext, "switch.s07_station_enabled");
		public SwitchEntity S08StationEnabled => new(_haContext, "switch.s08_station_enabled");
		public SwitchEntity S14StationEnabled => new(_haContext, "switch.s14_station_enabled");
		public SwitchEntity S15StationEnabled => new(_haContext, "switch.s15_station_enabled");
		public SwitchEntity S16StationEnabled => new(_haContext, "switch.s16_station_enabled");
		public SwitchEntity S17StationEnabled => new(_haContext, "switch.s17_station_enabled");
		public SwitchEntity S18StationEnabled => new(_haContext, "switch.s18_station_enabled");
		public SwitchEntity S19StationEnabled => new(_haContext, "switch.s19_station_enabled");
		public SwitchEntity S20StationEnabled => new(_haContext, "switch.s20_station_enabled");
		public SwitchEntity S21StationEnabled => new(_haContext, "switch.s21_station_enabled");
		public SwitchEntity S22StationEnabled => new(_haContext, "switch.s22_station_enabled");
		public SwitchEntity S23StationEnabled => new(_haContext, "switch.s23_station_enabled");
		public SwitchEntity S24StationEnabled => new(_haContext, "switch.s24_station_enabled");
		public SwitchEntity SecondHalfProgramEnabled => new(_haContext, "switch.second_half_program_enabled");
		public SwitchEntity SideBackGrassStationEnabled => new(_haContext, "switch.side_back_grass_station_enabled");
		public SwitchEntity SnapPeasAndSunflowersStationEnabled => new(_haContext, "switch.snap_peas_and_sunflowers_station_enabled");
		public SwitchEntity St1p1 => new(_haContext, "switch.st1p1");
		public SwitchEntity St1p2 => new(_haContext, "switch.st1p2");
		public SwitchEntity St1p3 => new(_haContext, "switch.st1p3");
		public SwitchEntity St1p4 => new(_haContext, "switch.st1p4");
		public SwitchEntity St2p1 => new(_haContext, "switch.st2p1");
		public SwitchEntity St2p2 => new(_haContext, "switch.st2p2");
		public SwitchEntity St2p3 => new(_haContext, "switch.st2p3");
		public SwitchEntity St2p4 => new(_haContext, "switch.st2p4");
		public SwitchEntity St3p1 => new(_haContext, "switch.st3p1");
		public SwitchEntity St3p2 => new(_haContext, "switch.st3p2");
		public SwitchEntity St3p3 => new(_haContext, "switch.st3p3");
		public SwitchEntity St3p4 => new(_haContext, "switch.st3p4");
		public SwitchEntity St4p1 => new(_haContext, "switch.st4p1");
		public SwitchEntity St4p2 => new(_haContext, "switch.st4p2");
		public SwitchEntity St4p3 => new(_haContext, "switch.st4p3");
		public SwitchEntity St4p4 => new(_haContext, "switch.st4p4");
		public SwitchEntity Tb4p2 => new(_haContext, "switch.tb4p2");
		public SwitchEntity Tb4p3 => new(_haContext, "switch.tb4p3");
		public SwitchEntity Tb4p4 => new(_haContext, "switch.tb4p4");
		public SwitchEntity Tbp1 => new(_haContext, "switch.tbp1");
		public SwitchEntity Valve => new(_haContext, "switch.valve");
		public SwitchEntity Valve2 => new(_haContext, "switch.valve_2");
		public SwitchEntity WellPTsAndAAStationEnabled => new(_haContext, "switch.well_p_ts_and_a_a_station_enabled");
		public SwitchEntity WonderStrawberriesStationEnabled => new(_haContext, "switch.wonder_strawberries_station_enabled");
	}

	public class WeatherEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public WeatherEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public WeatherEntity Home => new(_haContext, "weather.home");
		public WeatherEntity Openweathermap => new(_haContext, "weather.openweathermap");
	}

	public class ZoneEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ZoneEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public record AutomationEntity : NetDaemon.HassModel.Entities.Entity<AutomationEntity, NetDaemon.HassModel.Entities.EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record BinarySensorEntity : NetDaemon.HassModel.Entities.Entity<BinarySensorEntity, NetDaemon.HassModel.Entities.EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record CameraEntity : NetDaemon.HassModel.Entities.Entity<CameraEntity, NetDaemon.HassModel.Entities.EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record ClimateEntity : NetDaemon.HassModel.Entities.Entity<ClimateEntity, NetDaemon.HassModel.Entities.EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record DeviceTrackerEntity : NetDaemon.HassModel.Entities.Entity<DeviceTrackerEntity, NetDaemon.HassModel.Entities.EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record InputBooleanEntity : NetDaemon.HassModel.Entities.Entity<InputBooleanEntity, NetDaemon.HassModel.Entities.EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record InputNumberEntity : NetDaemon.HassModel.Entities.Entity<InputNumberEntity, NetDaemon.HassModel.Entities.EntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record InputSelectEntity : NetDaemon.HassModel.Entities.Entity<InputSelectEntity, NetDaemon.HassModel.Entities.EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record PersonEntity : NetDaemon.HassModel.Entities.Entity<PersonEntity, NetDaemon.HassModel.Entities.EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record ScriptEntity : NetDaemon.HassModel.Entities.Entity<ScriptEntity, NetDaemon.HassModel.Entities.EntityState<ScriptAttributes>, ScriptAttributes>
	{
		public ScriptEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record SensorEntity : NetDaemon.HassModel.Entities.Entity<SensorEntity, NetDaemon.HassModel.Entities.EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record SunEntity : NetDaemon.HassModel.Entities.Entity<SunEntity, NetDaemon.HassModel.Entities.EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record SwitchEntity : NetDaemon.HassModel.Entities.Entity<SwitchEntity, NetDaemon.HassModel.Entities.EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record WeatherEntity : NetDaemon.HassModel.Entities.Entity<WeatherEntity, NetDaemon.HassModel.Entities.EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record ZoneEntity : NetDaemon.HassModel.Entities.Entity<ZoneEntity, NetDaemon.HassModel.Entities.EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record AutomationAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_triggered")]
		public DateTime LastTriggered { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
		public long Current { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
		public long Id { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }
	}

	public record BinarySensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public long SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("release_notes")]
		public string ReleaseNotes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("newest_version")]
		public string NewestVersion { get; init; }
	}

	public record CameraAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("access_token")]
		public string AccessToken { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
		public string EntityPicture { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public long SupportedFeatures { get; init; }
	}

	public record ClimateAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("hvac_modes")]
		public List<string> HvacModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min_temp")]
		public long MinTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max_temp")]
		public long MaxTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("preset_modes")]
		public List<string> PresetModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current_temperature")]
		public long CurrentTemperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public long Temperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("hvac_action")]
		public string HvacAction { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("preset_mode")]
		public object PresetMode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public long SupportedFeatures { get; init; }
	}

	public record DeviceTrackerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source_type")]
		public string SourceType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("gps_accuracy")]
		public long GpsAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("altitude")]
		public double Altitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("course")]
		public long Course { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("speed")]
		public long Speed { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("vertical_accuracy")]
		public long VerticalAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }
	}

	public record InputBooleanAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }
	}

	public record InputNumberAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("initial")]
		public object Initial { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
		public double Min { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
		public double Max { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
		public double Step { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }
	}

	public record InputSelectAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
		public List<string> Options { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }
	}

	public record PersonAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
		public string Id { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("user_id")]
		public string UserId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }
	}

	public record ScriptAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_triggered")]
		public DateTime LastTriggered { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
		public long Current { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string Icon { get; init; }
	}

	public record SensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public long SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("sensor type")]
		public string Sensortype { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mac address")]
		public string Macaddress { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last packet id")]
		public string Lastpacketid { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("firmware")]
		public string Firmware { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("rssi")]
		public long Rssi { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("unit_of_measurement")]
		public string UnitOfMeasurement { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_level")]
		public long BatteryLevel { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("median")]
		public double Median { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mean")]
		public double Mean { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last median of")]
		public long Lastmedianof { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last mean of")]
		public long Lastmeanof { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("state_class")]
		public string StateClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_reset")]
		public DateTime LastReset { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
		public string Source { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
		public string Status { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_period")]
		public long LastPeriod { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("meter_period")]
		public string MeterPeriod { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("cron pattern")]
		public string Cronpattern { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("repositories")]
		public List<Dictionary<string, string>> Repositories { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("connected_not_paired_devices")]
		public string ConnectedNotPairedDevices { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("connected_paired_devices")]
		public string ConnectedPairedDevices { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("paired_devices")]
		public string PairedDevices { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Administrative Area")]
		public string AdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Country")]
		public string Country { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("ISO Country Code")]
		public string ISOCountryCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Latitude")]
		public double Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Locality")]
		public string Locality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Longitude")]
		public double Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Postal Code")]
		public long PostalCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Administrative Area")]
		public string SubAdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Locality")]
		public string SubLocality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Thoroughfare")]
		public long SubThoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Thoroughfare")]
		public string Thoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Local Time")]
		public string LocalTime { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Time in Milliseconds")]
		public long TimeinMilliseconds { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Package")]
		public string Package { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Free internal storage")]
		public string Freeinternalstorage { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Total internal storage")]
		public string Totalinternalstorage { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("is_hidden")]
		public bool IsHidden { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
		public string Integration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_loaded_apps")]
		public long NumberOfLoadedApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_running_apps")]
		public long NumberOfRunningApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
		public string Version { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string Attribution { get; init; }
	}

	public record SunAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dawn")]
		public DateTime NextDawn { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dusk")]
		public DateTime NextDusk { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_midnight")]
		public DateTime NextMidnight { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_noon")]
		public DateTime NextNoon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_rising")]
		public DateTime NextRising { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_setting")]
		public DateTime NextSetting { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("elevation")]
		public double Elevation { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("azimuth")]
		public double Azimuth { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("rising")]
		public bool Rising { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }
	}

	public record SwitchAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public long SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
		public string Integration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("runtime_info")]
		public Dictionary<string, DateTime> RuntimeInfo { get; init; }
	}

	public record WeatherAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public double Temperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("humidity")]
		public long Humidity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("pressure")]
		public double Pressure { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_bearing")]
		public double WindBearing { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_speed")]
		public long WindSpeed { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("forecast")]
		public List<Dictionary<string, string>> Forecast { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string Attribution { get; init; }
	}

	public record ZoneAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("radius")]
		public long Radius { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("passive")]
		public bool Passive { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string Icon { get; init; }
	}

	public interface IServices
	{
		AutomationServices Automation { get; }

		BleMonitorServices BleMonitor { get; }

		CameraServices Camera { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CounterServices Counter { get; }

		DeviceTrackerServices DeviceTracker { get; }

		EsphomeServices Esphome { get; }

		FrontendServices Frontend { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		InputBooleanServices InputBoolean { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LogbookServices Logbook { get; }

		LyricServices Lyric { get; }

		MqttServices Mqtt { get; }

		NetdaemonServices Netdaemon { get; }

		NotifyServices Notify { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		ShoppingListServices ShoppingList { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		UtilityMeterServices UtilityMeter { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public Services(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationServices Automation => new(_haContext);
		public BleMonitorServices BleMonitor => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public EsphomeServices Esphome => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LyricServices Lyric => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NetdaemonServices Netdaemon => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public ShoppingListServices ShoppingList => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public UtilityMeterServices UtilityMeter => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AutomationServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public AutomationServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new
			{
			@skip_condition = @skipCondition
			}

			);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new
			{
			@stop_actions = @stopActions
			}

			);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("skipCondition")]
		public bool SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("stopActions")]
		public bool StopActions { get; init; }
	}

	public class BleMonitorServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public BleMonitorServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void CleanupEntries()
		{
			_haContext.CallService("ble_monitor", "cleanup_entries", null);
		}
	}

	public class CameraServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CameraServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void DisableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		public void EnableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaPlayer, string? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new
			{
			@media_player = @mediaPlayer, @format = @format
			}

			);
		}

		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new
			{
			@filename = @filename, @duration = @duration, @lookback = @lookback
			}

			);
		}

		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new
			{
			@filename = @filename
			}

			);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("mediaPlayer")]
		public string MediaPlayer { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("format")]
		public string Format { get; init; }
	}

	public record CameraRecordParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("filename")]
		public string Filename { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long Duration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("lookback")]
		public long Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("filename")]
		public string Filename { get; init; }
	}

	public class ClimateServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ClimateServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new
			{
			@aux_heat = @auxHeat
			}

			);
		}

		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new
			{
			@fan_mode = @fanMode
			}

			);
		}

		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new
			{
			@humidity = @humidity
			}

			);
		}

		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new
			{
			@hvac_mode = @hvacMode
			}

			);
		}

		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new
			{
			@preset_mode = @presetMode
			}

			);
		}

		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new
			{
			@swing_mode = @swingMode
			}

			);
		}

		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new
			{
			@temperature = @temperature, @target_temp_high = @targetTempHigh, @target_temp_low = @targetTempLow, @hvac_mode = @hvacMode
			}

			);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("auxHeat")]
		public bool AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("fanMode")]
		public string FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("humidity")]
		public long Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("hvacMode")]
		public string HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("presetMode")]
		public string PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("swingMode")]
		public string SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("temperature")]
		public double Temperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("targetTempHigh")]
		public double TargetTempHigh { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("targetTempLow")]
		public double TargetTempLow { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("hvacMode")]
		public string HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CloudServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CounterServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CounterServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new
			{
			@minimum = @minimum, @maximum = @maximum, @step = @step, @initial = @initial, @value = @value
			}

			);
		}

		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		public void Reset(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("minimum")]
		public long Minimum { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("maximum")]
		public long Maximum { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("step")]
		public long Step { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("initial")]
		public long Initial { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public long Value { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public DeviceTrackerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new
			{
			@mac = @mac, @dev_id = @devId, @host_name = @hostName, @location_name = @locationName, @gps = @gps, @gps_accuracy = @gpsAccuracy, @battery = @battery
			}

			);
		}
	}

	public record DeviceTrackerSeeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("mac")]
		public string Mac { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("devId")]
		public string DevId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("hostName")]
		public string HostName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("locationName")]
		public string LocationName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("gps")]
		public object Gps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("gpsAccuracy")]
		public long GpsAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("battery")]
		public long Battery { get; init; }
	}

	public class EsphomeServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public EsphomeServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void PeristalticnutrientsNutrientpump1(EsphomePeristalticnutrientsNutrientpump1Parameters data)
		{
			_haContext.CallService("esphome", "peristalticnutrients_nutrientpump1", null, data);
		}

		public void PeristalticnutrientsNutrientpump1(long @target)
		{
			_haContext.CallService("esphome", "peristalticnutrients_nutrientpump1", null, new
			{
			@target = @target
			}

			);
		}

		public void PeristalticnutrientsNutrientpump2(EsphomePeristalticnutrientsNutrientpump2Parameters data)
		{
			_haContext.CallService("esphome", "peristalticnutrients_nutrientpump2", null, data);
		}

		public void PeristalticnutrientsNutrientpump2(long @target)
		{
			_haContext.CallService("esphome", "peristalticnutrients_nutrientpump2", null, new
			{
			@target = @target
			}

			);
		}

		public void PeristalticnutrientsNutrientpump3(EsphomePeristalticnutrientsNutrientpump3Parameters data)
		{
			_haContext.CallService("esphome", "peristalticnutrients_nutrientpump3", null, data);
		}

		public void PeristalticnutrientsNutrientpump3(long @target)
		{
			_haContext.CallService("esphome", "peristalticnutrients_nutrientpump3", null, new
			{
			@target = @target
			}

			);
		}
	}

	public record EsphomePeristalticnutrientsNutrientpump1Parameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public long Target { get; init; }
	}

	public record EsphomePeristalticnutrientsNutrientpump2Parameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public long Target { get; init; }
	}

	public record EsphomePeristalticnutrientsNutrientpump3Parameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public long Target { get; init; }
	}

	public class FrontendServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public FrontendServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		public void SetTheme(string @name, string? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new
			{
			@name = @name, @mode = @mode
			}

			);
		}
	}

	public record FrontendSetThemeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("mode")]
		public string Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public GroupServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new
			{
			@object_id = @objectId
			}

			);
		}

		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new
			{
			@object_id = @objectId, @name = @name, @icon = @icon, @entities = @entities, @add_entities = @addEntities, @all = @all
			}

			);
		}
	}

	public record GroupRemoveParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("objectId")]
		public object ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("objectId")]
		public string ObjectId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object Entities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("addEntities")]
		public object AddEntities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("all")]
		public bool All { get; init; }
	}

	public class HassioServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HassioServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new
			{
			@addon = @addon
			}

			);
		}

		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new
			{
			@addon = @addon
			}

			);
		}

		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new
			{
			@addon = @addon
			}

			);
		}

		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new
			{
			@addon = @addon
			}

			);
		}

		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new
			{
			@addon = @addon
			}

			);
		}

		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		public void BackupFull(string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new
			{
			@name = @name, @password = @password
			}

			);
		}

		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		public void BackupPartial(object? @addons = null, object? @folders = null, string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new
			{
			@addons = @addons, @folders = @folders, @name = @name, @password = @password
			}

			);
		}

		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new
			{
			@slug = @slug, @password = @password
			}

			);
		}

		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new
			{
			@slug = @slug, @homeassistant = @homeassistant, @folders = @folders, @addons = @addons, @password = @password
			}

			);
		}
	}

	public record HassioAddonRestartParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("addon")]
		public string Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string Password { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("addons")]
		public object Addons { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("folders")]
		public object Folders { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string Password { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("slug")]
		public string Slug { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("slug")]
		public string Slug { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("homeassistant")]
		public bool Homeassistant { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("folders")]
		public object Folders { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("addons")]
		public object Addons { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("password")]
		public string Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HomeassistantServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new
			{
			@entry_id = @entryId
			}

			);
		}

		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new
			{
			@latitude = @latitude, @longitude = @longitude
			}

			);
		}

		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		public void UpdateEntity(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entryId")]
		public string EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("latitude")]
		public string Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("longitude")]
		public string Longitude { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputBooleanServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputDatetimeServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputDatetimeServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new
			{
			@date = @date, @time = @time, @datetime = @datetime, @timestamp = @timestamp
			}

			);
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("date")]
		public string Date { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("time")]
		public DateTime Time { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("datetime")]
		public string Datetime { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("timestamp")]
		public long Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputNumberServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new
			{
			@value = @value
			}

			);
		}
	}

	public record InputNumberSetValueParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public double Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputSelectServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		public void SelectFirst(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		public void SelectLast(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new
			{
			@cycle = @cycle
			}

			);
		}

		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new
			{
			@option = @option
			}

			);
		}

		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new
			{
			@cycle = @cycle
			}

			);
		}

		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new
			{
			@options = @options
			}

			);
		}
	}

	public record InputSelectSelectNextParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("option")]
		public string Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("options")]
		public object Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputTextServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new
			{
			@value = @value
			}

			);
		}
	}

	public record InputTextSetValueParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public string Value { get; init; }
	}

	public class LogbookServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LogbookServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new
			{
			@name = @name, @message = @message, @entity_id = @entityId, @domain = @domain
			}

			);
		}
	}

	public record LogbookLogParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("domain")]
		public string Domain { get; init; }
	}

	public class LyricServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LyricServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void SetHoldTime(NetDaemon.HassModel.Entities.ServiceTarget target, LyricSetHoldTimeParameters data)
		{
			_haContext.CallService("lyric", "set_hold_time", target, data);
		}

		public void SetHoldTime(NetDaemon.HassModel.Entities.ServiceTarget target, string @timePeriod)
		{
			_haContext.CallService("lyric", "set_hold_time", target, new
			{
			@time_period = @timePeriod
			}

			);
		}
	}

	public record LyricSetHoldTimeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("timePeriod")]
		public string TimePeriod { get; init; }
	}

	public class MqttServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MqttServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new
			{
			@topic = @topic, @duration = @duration
			}

			);
		}

		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, string? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new
			{
			@topic = @topic, @payload = @payload, @payload_template = @payloadTemplate, @qos = @qos, @retain = @retain
			}

			);
		}
	}

	public record MqttDumpParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string Topic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string Topic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("payload")]
		public string Payload { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("payloadTemplate")]
		public object PayloadTemplate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("qos")]
		public string Qos { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("retain")]
		public bool Retain { get; init; }
	}

	public class NetdaemonServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NetdaemonServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void EntityCreate(NetdaemonEntityCreateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_create", null, data);
		}

		public void EntityCreate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new
			{
			@entity_id = @entityId, @state = @state, @icon = @icon, @unit = @unit, @attributes = @attributes
			}

			);
		}

		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		public void EntityRemove(string? @entityId = null)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, new
			{
			@entity_id = @entityId
			}

			);
		}

		public void EntityUpdate(NetdaemonEntityUpdateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_update", null, data);
		}

		public void EntityUpdate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new
			{
			@entity_id = @entityId, @state = @state, @icon = @icon, @unit = @unit, @attributes = @attributes
			}

			);
		}

		public void NutrientsAddnutrient()
		{
			_haContext.CallService("netdaemon", "nutrients_addnutrient", null);
		}

		public void NutrientsAddonedosetocurrentzone()
		{
			_haContext.CallService("netdaemon", "nutrients_addonedosetocurrentzone", null);
		}

		public void RefillRefillcurrentzone()
		{
			_haContext.CallService("netdaemon", "refill_refillcurrentzone", null);
		}

		public void RefillRefillwatertank()
		{
			_haContext.CallService("netdaemon", "refill_refillwatertank", null);
		}

		public void RegisterService(NetdaemonRegisterServiceParameters data)
		{
			_haContext.CallService("netdaemon", "register_service", null, data);
		}

		public void RegisterService(string? @class = null, string? @method = null)
		{
			_haContext.CallService("netdaemon", "register_service", null, new
			{
			@class = @class, @method = @method
			}

			);
		}

		public void ReloadApps()
		{
			_haContext.CallService("netdaemon", "reload_apps", null);
		}
	}

	public record NetdaemonEntityCreateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string State { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string Unit { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string State { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string Unit { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("class")]
		public string Class { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("method")]
		public string Method { get; init; }
	}

	public class NotifyServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NotifyServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void MobileAppMotoGStylus(NotifyMobileAppMotoGStylusParameters data)
		{
			_haContext.CallService("notify", "mobile_app_moto_g_stylus", null, data);
		}

		public void MobileAppMotoGStylus(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_moto_g_stylus", null, new
			{
			@message = @message, @title = @title, @target = @target, @data = @data
			}

			);
		}

		public void MobileAppSamsungflex(NotifyMobileAppSamsungflexParameters data)
		{
			_haContext.CallService("notify", "mobile_app_samsungflex", null, data);
		}

		public void MobileAppSamsungflex(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_samsungflex", null, new
			{
			@message = @message, @title = @title, @target = @target, @data = @data
			}

			);
		}

		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new
			{
			@message = @message, @title = @title, @target = @target, @data = @data
			}

			);
		}

		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new
			{
			@message = @message, @title = @title
			}

			);
		}
	}

	public record NotifyMobileAppMotoGStylusParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object Target { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object Data { get; init; }
	}

	public record NotifyMobileAppSamsungflexParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object Target { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object Target { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string Title { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersistentNotificationServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new
			{
			@message = @message, @title = @title, @notification_id = @notificationId
			}

			);
		}

		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new
			{
			@notification_id = @notificationId
			}

			);
		}

		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new
			{
			@notification_id = @notificationId
			}

			);
		}
	}

	public record PersistentNotificationCreateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersonServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public RecorderServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new
			{
			@keep_days = @keepDays, @repack = @repack, @apply_filter = @applyFilter
			}

			);
		}

		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new
			{
			@domains = @domains, @entity_globs = @entityGlobs
			}

			);
		}
	}

	public record RecorderPurgeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("keepDays")]
		public long KeepDays { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("repack")]
		public bool Repack { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("applyFilter")]
		public bool ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("domains")]
		public object Domains { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entityGlobs")]
		public object EntityGlobs { get; init; }
	}

	public class SceneServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SceneServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new
			{
			@entities = @entities, @transition = @transition
			}

			);
		}

		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new
			{
			@scene_id = @sceneId, @entities = @entities, @snapshot_entities = @snapshotEntities
			}

			);
		}

		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new
			{
			@transition = @transition
			}

			);
		}
	}

	public record SceneApplyParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object Entities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("sceneId")]
		public string SceneId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object Entities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("snapshotEntities")]
		public object SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ScriptServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void AddDoseToCurrentZone()
		{
			_haContext.CallService("script", "add_dose_to_current_zone", null);
		}

		public void MovePump1()
		{
			_haContext.CallService("script", "move_pump_1", null);
		}

		public void MovePump2()
		{
			_haContext.CallService("script", "move_pump_2", null);
		}

		public void MovePump3()
		{
			_haContext.CallService("script", "move_pump_3", null);
		}

		public void RefillCurrentBucket()
		{
			_haContext.CallService("script", "refill_current_bucket", null);
		}

		public void RefillFreshWaterTank()
		{
			_haContext.CallService("script", "refill_fresh_water_tank", null);
		}

		public void RefillSwpCooler()
		{
			_haContext.CallService("script", "refill_swp_cooler", null);
		}

		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class ShoppingListServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ShoppingListServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void AddItem(ShoppingListAddItemParameters data)
		{
			_haContext.CallService("shopping_list", "add_item", null, data);
		}

		public void AddItem(string @name)
		{
			_haContext.CallService("shopping_list", "add_item", null, new
			{
			@name = @name
			}

			);
		}

		public void ClearCompletedItems()
		{
			_haContext.CallService("shopping_list", "clear_completed_items", null);
		}

		public void CompleteAll()
		{
			_haContext.CallService("shopping_list", "complete_all", null);
		}

		public void CompleteItem(ShoppingListCompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "complete_item", null, data);
		}

		public void CompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "complete_item", null, new
			{
			@name = @name
			}

			);
		}

		public void IncompleteAll()
		{
			_haContext.CallService("shopping_list", "incomplete_all", null);
		}

		public void IncompleteItem(ShoppingListIncompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, data);
		}

		public void IncompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, new
			{
			@name = @name
			}

			);
		}
	}

	public record ShoppingListAddItemParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }
	}

	public record ShoppingListCompleteItemParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }
	}

	public record ShoppingListIncompleteItemParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string Name { get; init; }
	}

	public class SwitchServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SystemLogServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		public void Write(string @message, string? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new
			{
			@message = @message, @level = @level, @logger = @logger
			}

			);
		}
	}

	public record SystemLogWriteParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("level")]
		public string Level { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("logger")]
		public string Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TemplateServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TimerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Cancel(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		public void Finish(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new
			{
			@duration = @duration
			}

			);
		}
	}

	public record TimerStartParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public string Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TtsServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		public void CloudSay(TtsCloudSayParameters data)
		{
			_haContext.CallService("tts", "cloud_say", null, data);
		}

		public void CloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "cloud_say", null, new
			{
			@entity_id = @entityId, @message = @message, @cache = @cache, @language = @language, @options = @options
			}

			);
		}

		public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data)
		{
			_haContext.CallService("tts", "google_translate_say", null, data);
		}

		public void GoogleTranslateSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_translate_say", null, new
			{
			@entity_id = @entityId, @message = @message, @cache = @cache, @language = @language, @options = @options
			}

			);
		}
	}

	public record TtsCloudSayParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("cache")]
		public bool Cache { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("language")]
		public string Language { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("options")]
		public object Options { get; init; }
	}

	public record TtsGoogleTranslateSayParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("cache")]
		public bool Cache { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("language")]
		public string Language { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("options")]
		public object Options { get; init; }
	}

	public class UtilityMeterServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public UtilityMeterServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Calibrate(NetDaemon.HassModel.Entities.ServiceTarget target, UtilityMeterCalibrateParameters data)
		{
			_haContext.CallService("utility_meter", "calibrate", target, data);
		}

		public void Calibrate(NetDaemon.HassModel.Entities.ServiceTarget target, string @value)
		{
			_haContext.CallService("utility_meter", "calibrate", target, new
			{
			@value = @value
			}

			);
		}
	}

	public record UtilityMeterCalibrateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public string Value { get; init; }
	}

	public class ZoneServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ZoneServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		public static void Toggle(this AutomationEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void Trigger(this AutomationEntity entity, AutomationTriggerParameters data)
		{
			entity.CallService("trigger", data);
		}

		public static void Trigger(this AutomationEntity entity, bool? @skipCondition = null)
		{
			entity.CallService("trigger", new
			{
			@skip_condition = @skipCondition
			}

			);
		}

		public static void TurnOff(this AutomationEntity entity, AutomationTurnOffParameters data)
		{
			entity.CallService("turn_off", data);
		}

		public static void TurnOff(this AutomationEntity entity, bool? @stopActions = null)
		{
			entity.CallService("turn_off", new
			{
			@stop_actions = @stopActions
			}

			);
		}

		public static void TurnOn(this AutomationEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		public static void DisableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("disable_motion_detection");
		}

		public static void EnableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("enable_motion_detection");
		}

		public static void PlayStream(this CameraEntity entity, CameraPlayStreamParameters data)
		{
			entity.CallService("play_stream", data);
		}

		public static void PlayStream(this CameraEntity entity, string @mediaPlayer, string? @format = null)
		{
			entity.CallService("play_stream", new
			{
			@media_player = @mediaPlayer, @format = @format
			}

			);
		}

		public static void Record(this CameraEntity entity, CameraRecordParameters data)
		{
			entity.CallService("record", data);
		}

		public static void Record(this CameraEntity entity, string @filename, long? @duration = null, long? @lookback = null)
		{
			entity.CallService("record", new
			{
			@filename = @filename, @duration = @duration, @lookback = @lookback
			}

			);
		}

		public static void Snapshot(this CameraEntity entity, CameraSnapshotParameters data)
		{
			entity.CallService("snapshot", data);
		}

		public static void Snapshot(this CameraEntity entity, string @filename)
		{
			entity.CallService("snapshot", new
			{
			@filename = @filename
			}

			);
		}

		public static void TurnOff(this CameraEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this CameraEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		public static void SetAuxHeat(this ClimateEntity entity, ClimateSetAuxHeatParameters data)
		{
			entity.CallService("set_aux_heat", data);
		}

		public static void SetAuxHeat(this ClimateEntity entity, bool @auxHeat)
		{
			entity.CallService("set_aux_heat", new
			{
			@aux_heat = @auxHeat
			}

			);
		}

		public static void SetFanMode(this ClimateEntity entity, ClimateSetFanModeParameters data)
		{
			entity.CallService("set_fan_mode", data);
		}

		public static void SetFanMode(this ClimateEntity entity, string @fanMode)
		{
			entity.CallService("set_fan_mode", new
			{
			@fan_mode = @fanMode
			}

			);
		}

		public static void SetHumidity(this ClimateEntity entity, ClimateSetHumidityParameters data)
		{
			entity.CallService("set_humidity", data);
		}

		public static void SetHumidity(this ClimateEntity entity, long @humidity)
		{
			entity.CallService("set_humidity", new
			{
			@humidity = @humidity
			}

			);
		}

		public static void SetHvacMode(this ClimateEntity entity, ClimateSetHvacModeParameters data)
		{
			entity.CallService("set_hvac_mode", data);
		}

		public static void SetHvacMode(this ClimateEntity entity, string? @hvacMode = null)
		{
			entity.CallService("set_hvac_mode", new
			{
			@hvac_mode = @hvacMode
			}

			);
		}

		public static void SetPresetMode(this ClimateEntity entity, ClimateSetPresetModeParameters data)
		{
			entity.CallService("set_preset_mode", data);
		}

		public static void SetPresetMode(this ClimateEntity entity, string @presetMode)
		{
			entity.CallService("set_preset_mode", new
			{
			@preset_mode = @presetMode
			}

			);
		}

		public static void SetSwingMode(this ClimateEntity entity, ClimateSetSwingModeParameters data)
		{
			entity.CallService("set_swing_mode", data);
		}

		public static void SetSwingMode(this ClimateEntity entity, string @swingMode)
		{
			entity.CallService("set_swing_mode", new
			{
			@swing_mode = @swingMode
			}

			);
		}

		public static void SetTemperature(this ClimateEntity entity, ClimateSetTemperatureParameters data)
		{
			entity.CallService("set_temperature", data);
		}

		public static void SetTemperature(this ClimateEntity entity, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			entity.CallService("set_temperature", new
			{
			@temperature = @temperature, @target_temp_high = @targetTempHigh, @target_temp_low = @targetTempLow, @hvac_mode = @hvacMode
			}

			);
		}

		public static void TurnOff(this ClimateEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this ClimateEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		public static void Toggle(this InputBooleanEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void TurnOff(this InputBooleanEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this InputBooleanEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		public static void Decrement(this InputNumberEntity entity)
		{
			entity.CallService("decrement");
		}

		public static void Increment(this InputNumberEntity entity)
		{
			entity.CallService("increment");
		}

		public static void SetValue(this InputNumberEntity entity, InputNumberSetValueParameters data)
		{
			entity.CallService("set_value", data);
		}

		public static void SetValue(this InputNumberEntity entity, double @value)
		{
			entity.CallService("set_value", new
			{
			@value = @value
			}

			);
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		public static void SelectFirst(this InputSelectEntity entity)
		{
			entity.CallService("select_first");
		}

		public static void SelectLast(this InputSelectEntity entity)
		{
			entity.CallService("select_last");
		}

		public static void SelectNext(this InputSelectEntity entity, InputSelectSelectNextParameters data)
		{
			entity.CallService("select_next", data);
		}

		public static void SelectNext(this InputSelectEntity entity, bool? @cycle = null)
		{
			entity.CallService("select_next", new
			{
			@cycle = @cycle
			}

			);
		}

		public static void SelectOption(this InputSelectEntity entity, InputSelectSelectOptionParameters data)
		{
			entity.CallService("select_option", data);
		}

		public static void SelectOption(this InputSelectEntity entity, string @option)
		{
			entity.CallService("select_option", new
			{
			@option = @option
			}

			);
		}

		public static void SelectPrevious(this InputSelectEntity entity, InputSelectSelectPreviousParameters data)
		{
			entity.CallService("select_previous", data);
		}

		public static void SelectPrevious(this InputSelectEntity entity, bool? @cycle = null)
		{
			entity.CallService("select_previous", new
			{
			@cycle = @cycle
			}

			);
		}

		public static void SetOptions(this InputSelectEntity entity, InputSelectSetOptionsParameters data)
		{
			entity.CallService("set_options", data);
		}

		public static void SetOptions(this InputSelectEntity entity, object @options)
		{
			entity.CallService("set_options", new
			{
			@options = @options
			}

			);
		}
	}

	public static class LyricEntityExtensionMethods
	{
		public static void SetHoldTime(this ClimateEntity entity, LyricSetHoldTimeParameters data)
		{
			entity.CallService("set_hold_time", data);
		}

		public static void SetHoldTime(this ClimateEntity entity, string @timePeriod)
		{
			entity.CallService("set_hold_time", new
			{
			@time_period = @timePeriod
			}

			);
		}
	}

	public static class ScriptEntityExtensionMethods
	{
		public static void Toggle(this ScriptEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void TurnOff(this ScriptEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this ScriptEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		public static void Toggle(this SwitchEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void TurnOff(this SwitchEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this SwitchEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class UtilityMeterEntityExtensionMethods
	{
		public static void Calibrate(this SensorEntity entity, UtilityMeterCalibrateParameters data)
		{
			entity.CallService("calibrate", data);
		}

		public static void Calibrate(this SensorEntity entity, string @value)
		{
			entity.CallService("calibrate", new
			{
			@value = @value
			}

			);
		}
	}
}