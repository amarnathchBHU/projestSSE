// ------------------------------------------------------------------------------
//                    Copyright (c) 2021 Medtronic, Inc.
// This software is copyrighted by and is the sole property of Medtronic/Covidien. This
// is a proprietary work to which Medtronic/Covidien claims exclusive right.  No part
// of this work may be used, disclosed, reproduced, stored in an information
// retrieval system, or transmitted by any means, electronic, mechanical,
// photocopying, recording, or otherwise without the prior written permission
// of Medtronic/Covidien.
// ------------------------------------------------------------------------------

namespace Oasis.Agent.Models.Responses
{
    using System.Collections.Generic;

    using Oasis.Agent.Models;

    public class StatDeviceResp : ResultBase
    {
        public bool Exists { get; set; }

        public SystemConfigs SystemConfigs { get; set; } = default;

        public List<Feature> FeatureComponents { get; set; } = default;
    }
}