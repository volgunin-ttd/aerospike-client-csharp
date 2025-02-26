/* 
 * Copyright 2012-2025 Aerospike, Inc.
 *
 * Portions may be licensed to Aerospike, Inc. under one or more contributor
 * license agreements.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

namespace Aerospike.Client
{
	/// <summary>
	/// Transaction policy fields used to batch verify record versions on commit.
    /// Used a placeholder for now as there are no additional fields beyond BatchPolicy.
	/// </summary>
	public sealed class TxnVerifyPolicy : BatchPolicy
	{
		/// <summary>
		/// Copy policy from another policy.
		/// </summary>
		public TxnVerifyPolicy(TxnVerifyPolicy other) : 
			base(other)
		{
		}

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TxnVerifyPolicy()
		{
			readModeSC = ReadModeSC.LINEARIZE;
			replica = Replica.MASTER;
			maxRetries = 5;
			socketTimeout = 3000;
			totalTimeout = 10000;
			sleepBetweenRetries = 1000;
		}

		/// <summary>
		/// Creates a deep copy of this txn verify policy.
		/// </summary>
		/// <returns></returns>
		public new TxnVerifyPolicy Clone()
		{
			return new TxnVerifyPolicy(this);
		}
	}
}
