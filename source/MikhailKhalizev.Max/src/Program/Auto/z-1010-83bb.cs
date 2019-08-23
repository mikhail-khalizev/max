using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_83bb-588af350")]
        public void Method_1010_83bb()
        {
            ii(0x1010_83bb, 5); pushd(0x8c);                            /* push 0x8c */
            ii(0x1010_83c0, 5); calld(Definitions.sys_check_available_stack_size, 0x5_d98d); /* call 0x10165d52 */
            ii(0x1010_83c5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_83c6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_83c7, 1); pushd(esi);                             /* push esi */
            ii(0x1010_83c8, 1); pushd(edi);                             /* push edi */
            ii(0x1010_83c9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_83ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_83cc, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x1010_83d2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_83d5, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_83d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_83db, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_83dd, 4); cmp(memb_a32[ds, eax + 0x1], 0x3a);     /* cmp byte [eax+0x1], 0x3a */
            ii(0x1010_83e1, 2); if(jnzd(0x1010_842c, 0x49)) goto l_0x1010_842c; /* jnz 0x1010842c */
            ii(0x1010_83e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_83e6, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_83e8, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_83eb, 5); calld(Definitions.sys_strcpy, 0x5_dadf); /* call 0x10165ecf */
            ii(0x1010_83f0, 3); lea(eax, ebp - 0x70);                   /* lea eax, [ebp-0x70] */
            ii(0x1010_83f3, 5); calld(Definitions.sys_strlen, 0x6_9acf); /* call 0x10171ec7 */
            ii(0x1010_83f8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1010_83fb:
            ii(0x1010_83fb, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1010_83fe, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_8403, 2); if(jzd(0x1010_841d, 0x18)) goto l_0x1010_841d; /* jz 0x1010841d */
            ii(0x1010_8405, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8409, 5); cmp(memb_a32[ds, eax + ebp - 0x70], 0x5c); /* cmp byte [eax+ebp-0x70], 0x5c */
            ii(0x1010_840e, 2); if(jnzd(0x1010_841b, 0xb)) goto l_0x1010_841b; /* jnz 0x1010841b */
            ii(0x1010_8410, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8414, 5); mov(memb_a32[ds, eax + ebp - 0x6f], 0); /* mov byte [eax+ebp-0x6f], 0x0 */
            ii(0x1010_8419, 2); jmpd(0x1010_841d, 0x2); goto l_0x1010_841d; /* jmp 0x1010841d */
        l_0x1010_841b:
            ii(0x1010_841b, 2); jmpd(0x1010_83fb, -0x22); goto l_0x1010_83fb; /* jmp 0x101083fb */
        l_0x1010_841d:
            ii(0x1010_841d, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8421, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_8424, 2); if(jged(0x1010_842a, 0x4)) goto l_0x1010_842a; /* jge 0x1010842a */
            ii(0x1010_8426, 4); mov(memb_a32[ss, ebp - 0x6e], 0);       /* mov byte [ebp-0x6e], 0x0 */
        l_0x1010_842a:
            ii(0x1010_842a, 2); jmpd(0x1010_8430, 0x4); goto l_0x1010_8430; /* jmp 0x10108430 */
        l_0x1010_842c:
            ii(0x1010_842c, 4); mov(memb_a32[ss, ebp - 0x70], 0);       /* mov byte [ebp-0x70], 0x0 */
        l_0x1010_8430:
            ii(0x1010_8430, 7); mov(memb_a32[ds, 0x101c_3d0c], 0);      /* mov byte [0x101c3d0c], 0x0 */
            ii(0x1010_8437, 7); mov(memb_a32[ds, 0x101c_3d70], 0);      /* mov byte [0x101c3d70], 0x0 */
            ii(0x1010_843e, 7); mov(memb_a32[ds, 0x101c_3dd4], 0);      /* mov byte [0x101c3dd4], 0x0 */
            ii(0x1010_8445, 7); mov(memb_a32[ds, 0x101c_3e38], 0);      /* mov byte [0x101c3e38], 0x0 */
            ii(0x1010_844c, 7); mov(memb_a32[ds, 0x101c_3e9c], 0);      /* mov byte [0x101c3e9c], 0x0 */
            ii(0x1010_8453, 7); mov(memb_a32[ds, 0x101c_3f00], 0);      /* mov byte [0x101c3f00], 0x0 */
            ii(0x1010_845a, 7); mov(memb_a32[ds, 0x101c_3f64], 0);      /* mov byte [0x101c3f64], 0x0 */
            ii(0x1010_8461, 7); mov(memb_a32[ds, 0x101c_3fc8], 0);      /* mov byte [0x101c3fc8], 0x0 */
            ii(0x1010_8468, 7); mov(memb_a32[ds, 0x101c_402c], 0);      /* mov byte [0x101c402c], 0x0 */
            ii(0x1010_846f, 7); mov(memb_a32[ds, 0x101c_4dcc], 0);      /* mov byte [0x101c4dcc], 0x0 */
            ii(0x1010_8476, 5); calld(0x1010_81f4, -0x287);             /* call 0x101081f4 */
            ii(0x1010_847b, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_8482, 2); jmpd(0x1010_848a, 0x6); goto l_0x1010_848a; /* jmp 0x1010848a */
        l_0x1010_8484:
            ii(0x1010_8484, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8487, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1010_848a:
            ii(0x1010_848a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_848d, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1010_8491, 6); if(jged(0x1010_878c, 0x2f5)) goto l_0x1010_878c; /* jge 0x1010878c */
            ii(0x1010_8497, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_849b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_849e, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_84a1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_84a3, 5); calld(/* sys */ 0x1017_931d, 0x7_0e75); /* call 0x1017931d */
            ii(0x1010_84a8, 5); mov(edx, StringDefinitions.S);          /* mov edx, 0x101a44dc */
            ii(0x1010_84ad, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_84b1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_84b4, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_84b7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_84b9, 5); calld(Definitions.sys_strstr, 0x7_0b52); /* call 0x10179010 */
            ii(0x1010_84be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_84c0, 2); if(jnzd(0x1010_84dc, 0x1a)) goto l_0x1010_84dc; /* jnz 0x101084dc */
            ii(0x1010_84c2, 5); mov(edx, StringDefinitions.M);          /* mov edx, 0x101a44df */
            ii(0x1010_84c7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_84cb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_84ce, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_84d1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_84d3, 5); calld(Definitions.sys_strstr, 0x7_0b38); /* call 0x10179010 */
            ii(0x1010_84d8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_84da, 2); if(jzd(0x1010_84de, 0x2)) goto l_0x1010_84de; /* jz 0x101084de */
        l_0x1010_84dc:
            ii(0x1010_84dc, 2); jmpd(0x1010_84f8, 0x1a); goto l_0x1010_84f8; /* jmp 0x101084f8 */
        l_0x1010_84de:
            ii(0x1010_84de, 5); mov(edx, StringDefinitions.L);          /* mov edx, 0x101a44e2 */
            ii(0x1010_84e3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_84e7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_84ea, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_84ed, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_84ef, 5); calld(Definitions.sys_strstr, 0x7_0b1c); /* call 0x10179010 */
            ii(0x1010_84f4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_84f6, 2); if(jzd(0x1010_84fa, 0x2)) goto l_0x1010_84fa; /* jz 0x101084fa */
        l_0x1010_84f8:
            ii(0x1010_84f8, 2); jmpd(0x1010_8518, 0x1e); goto l_0x1010_8518; /* jmp 0x10108518 */
        l_0x1010_84fa:
            ii(0x1010_84fa, 5); mov(edx, StringDefinitions.F4);         /* mov edx, 0x101a44e5 */
            ii(0x1010_84ff, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8503, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_8506, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_8509, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_850b, 5); calld(Definitions.sys_strstr, 0x7_0b00); /* call 0x10179010 */
            ii(0x1010_8510, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8512, 6); if(jzd(0x1010_8787, 0x26f)) goto l_0x1010_8787; /* jz 0x10108787 */
        l_0x1010_8518:
            ii(0x1010_8518, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_851c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_851f, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_8522, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_8524, 3); lea(edx, eax + 0x2);                    /* lea edx, [eax+0x2] */
            ii(0x1010_8527, 5); mov(eax, 0x101c_3d0c);                  /* mov eax, 0x101c3d0c */
            ii(0x1010_852c, 5); calld(Definitions.sys_strcpy, 0x5_d99e); /* call 0x10165ecf */
            ii(0x1010_8531, 5); mov(eax, 0x101c_3d0c);                  /* mov eax, 0x101c3d0c */
            ii(0x1010_8536, 5); calld(/* sys */ 0x1017_9342, 0x7_0e07); /* call 0x10179342 */
            ii(0x1010_853b, 5); mov(edx, StringDefinitions.S3);         /* mov edx, 0x101a44e8 */
            ii(0x1010_8540, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8544, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_8547, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_854a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_854c, 5); calld(Definitions.sys_strstr, 0x7_0abf); /* call 0x10179010 */
            ii(0x1010_8551, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8553, 2); if(jnzd(0x1010_856f, 0x1a)) goto l_0x1010_856f; /* jnz 0x1010856f */
            ii(0x1010_8555, 5); mov(edx, StringDefinitions.M2);         /* mov edx, 0x101a44eb */
            ii(0x1010_855a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_855e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_8561, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_8564, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_8566, 5); calld(Definitions.sys_strstr, 0x7_0aa5); /* call 0x10179010 */
            ii(0x1010_856b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_856d, 2); if(jzd(0x1010_8571, 0x2)) goto l_0x1010_8571; /* jz 0x10108571 */
        l_0x1010_856f:
            ii(0x1010_856f, 2); jmpd(0x1010_858f, 0x1e); goto l_0x1010_858f; /* jmp 0x1010858f */
        l_0x1010_8571:
            ii(0x1010_8571, 5); mov(edx, StringDefinitions.L4);         /* mov edx, 0x101a44ee */
            ii(0x1010_8576, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_857a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_857d, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_8580, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_8582, 5); calld(Definitions.sys_strstr, 0x7_0a89); /* call 0x10179010 */
            ii(0x1010_8587, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8589, 6); if(jzd(0x1010_866f, 0xe0)) goto l_0x1010_866f; /* jz 0x1010866f */
        l_0x1010_858f:
            ii(0x1010_858f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_8591, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_8593, 5); calld(0x1010_8905, 0x36d);              /* call 0x10108905 */
            ii(0x1010_8598, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_859a, 2); if(jnzd(0x1010_85b4, 0x18)) goto l_0x1010_85b4; /* jnz 0x101085b4 */
            ii(0x1010_859c, 5); mov(eax, StringDefinitions.PleaseInsertTheMAXCdAndTryAgain2); /* mov eax, 0x101a44f1 */
            ii(0x1010_85a1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_85a2, 5); calld(Definitions.sys_printf, 0x6_4095); /* call 0x1016c63c */
            ii(0x1010_85a7, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1010_85aa, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_85af, 5); calld(Definitions.sys_exit, 0x6_40ab);  /* call 0x1016c65f */
        l_0x1010_85b4:
            ii(0x1010_85b4, 7); mov(memb_a32[ds, 0x101c_4dcc], 0x1);    /* mov byte [0x101c4dcc], 0x1 */
            ii(0x1010_85bb, 5); mov(edx, 0x101c_3d0c);                  /* mov edx, 0x101c3d0c */
            ii(0x1010_85c0, 5); mov(eax, 0x101c_3e38);                  /* mov eax, 0x101c3e38 */
            ii(0x1010_85c5, 5); calld(Definitions.sys_strcpy, 0x5_d905); /* call 0x10165ecf */
            ii(0x1010_85ca, 5); mov(edx, 0x101c_3d0c);                  /* mov edx, 0x101c3d0c */
            ii(0x1010_85cf, 5); mov(eax, 0x101c_3e9c);                  /* mov eax, 0x101c3e9c */
            ii(0x1010_85d4, 5); calld(Definitions.sys_strcpy, 0x5_d8f6); /* call 0x10165ecf */
            ii(0x1010_85d9, 5); mov(edx, 0x101c_3d0c);                  /* mov edx, 0x101c3d0c */
            ii(0x1010_85de, 5); mov(eax, 0x101c_3f00);                  /* mov eax, 0x101c3f00 */
            ii(0x1010_85e3, 5); calld(Definitions.sys_strcpy, 0x5_d8e7); /* call 0x10165ecf */
            ii(0x1010_85e8, 5); mov(edx, 0x101c_3d0c);                  /* mov edx, 0x101c3d0c */
            ii(0x1010_85ed, 5); mov(eax, 0x101c_3f64);                  /* mov eax, 0x101c3f64 */
            ii(0x1010_85f2, 5); calld(Definitions.sys_strcpy, 0x5_d8d8); /* call 0x10165ecf */
            ii(0x1010_85f7, 5); mov(edx, 0x101c_3d0c);                  /* mov edx, 0x101c3d0c */
            ii(0x1010_85fc, 5); mov(eax, 0x101c_3fc8);                  /* mov eax, 0x101c3fc8 */
            ii(0x1010_8601, 5); calld(Definitions.sys_strcpy, 0x5_d8c9); /* call 0x10165ecf */
            ii(0x1010_8606, 5); mov(edx, 0x101c_3d0c);                  /* mov edx, 0x101c3d0c */
            ii(0x1010_860b, 5); mov(eax, 0x101c_402c);                  /* mov eax, 0x101c402c */
            ii(0x1010_8610, 5); calld(Definitions.sys_strcpy, 0x5_d8ba); /* call 0x10165ecf */
            ii(0x1010_8615, 5); mov(edx, StringDefinitions.Control12);  /* mov edx, 0x101a451f */
            ii(0x1010_861a, 5); mov(eax, 0x101c_3e38);                  /* mov eax, 0x101c3e38 */
            ii(0x1010_861f, 5); calld(Definitions.sys_strcat, 0x5_d90d); /* call 0x10165f31 */
            ii(0x1010_8624, 5); mov(edx, StringDefinitions.Control13);  /* mov edx, 0x101a4521 */
            ii(0x1010_8629, 5); mov(eax, 0x101c_3e9c);                  /* mov eax, 0x101c3e9c */
            ii(0x1010_862e, 5); calld(Definitions.sys_strcat, 0x5_d8fe); /* call 0x10165f31 */
            ii(0x1010_8633, 5); mov(edx, StringDefinitions.Control14);  /* mov edx, 0x101a4523 */
            ii(0x1010_8638, 5); mov(eax, 0x101c_3f00);                  /* mov eax, 0x101c3f00 */
            ii(0x1010_863d, 5); calld(Definitions.sys_strcat, 0x5_d8ef); /* call 0x10165f31 */
            ii(0x1010_8642, 5); mov(edx, StringDefinitions.Control15);  /* mov edx, 0x101a4525 */
            ii(0x1010_8647, 5); mov(eax, 0x101c_3f64);                  /* mov eax, 0x101c3f64 */
            ii(0x1010_864c, 5); calld(Definitions.sys_strcat, 0x5_d8e0); /* call 0x10165f31 */
            ii(0x1010_8651, 5); mov(edx, StringDefinitions.Control16);  /* mov edx, 0x101a4527 */
            ii(0x1010_8656, 5); mov(eax, 0x101c_3fc8);                  /* mov eax, 0x101c3fc8 */
            ii(0x1010_865b, 5); calld(Definitions.sys_strcat, 0x5_d8d1); /* call 0x10165f31 */
            ii(0x1010_8660, 5); mov(edx, StringDefinitions.Control17);  /* mov edx, 0x101a4529 */
            ii(0x1010_8665, 5); mov(eax, 0x101c_402c);                  /* mov eax, 0x101c402c */
            ii(0x1010_866a, 5); calld(Definitions.sys_strcat, 0x5_d8c2); /* call 0x10165f31 */
        l_0x1010_866f:
            ii(0x1010_866f, 3); lea(edx, ebp - 0x70);                   /* lea edx, [ebp-0x70] */
            ii(0x1010_8672, 5); mov(eax, 0x101c_3d70);                  /* mov eax, 0x101c3d70 */
            ii(0x1010_8677, 5); calld(Definitions.sys_strcpy, 0x5_d853); /* call 0x10165ecf */
            ii(0x1010_867c, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_8681, 5); mov(eax, 0x101c_3dd4);                  /* mov eax, 0x101c3dd4 */
            ii(0x1010_8686, 5); calld(Definitions.sys_strcpy, 0x5_d844); /* call 0x10165ecf */
            ii(0x1010_868b, 5); mov(edx, StringDefinitions.M3);         /* mov edx, 0x101a452b */
            ii(0x1010_8690, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8694, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_8697, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_869a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_869c, 5); calld(Definitions.sys_strstr, 0x7_096f); /* call 0x10179010 */
            ii(0x1010_86a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_86a3, 2); if(jnzd(0x1010_86bf, 0x1a)) goto l_0x1010_86bf; /* jnz 0x101086bf */
            ii(0x1010_86a5, 5); mov(edx, StringDefinitions.L2);         /* mov edx, 0x101a452e */
            ii(0x1010_86aa, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_86ae, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_86b1, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_86b4, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_86b6, 5); calld(Definitions.sys_strstr, 0x7_0955); /* call 0x10179010 */
            ii(0x1010_86bb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_86bd, 2); if(jzd(0x1010_86c1, 0x2)) goto l_0x1010_86c1; /* jz 0x101086c1 */
        l_0x1010_86bf:
            ii(0x1010_86bf, 2); jmpd(0x1010_86df, 0x1e); goto l_0x1010_86df; /* jmp 0x101086df */
        l_0x1010_86c1:
            ii(0x1010_86c1, 5); mov(edx, StringDefinitions.F3);         /* mov edx, 0x101a4531 */
            ii(0x1010_86c6, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_86ca, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_86cd, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_86d0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_86d2, 5); calld(Definitions.sys_strstr, 0x7_0939); /* call 0x10179010 */
            ii(0x1010_86d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_86d9, 6); if(jzd(0x1010_8787, 0xa8)) goto l_0x1010_8787; /* jz 0x10108787 */
        l_0x1010_86df:
            ii(0x1010_86df, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_86e4, 5); mov(eax, 0x101c_3e38);                  /* mov eax, 0x101c3e38 */
            ii(0x1010_86e9, 5); calld(Definitions.sys_strcpy, 0x5_d7e1); /* call 0x10165ecf */
            ii(0x1010_86ee, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_86f3, 5); mov(eax, 0x101c_3f64);                  /* mov eax, 0x101c3f64 */
            ii(0x1010_86f8, 5); calld(Definitions.sys_strcpy, 0x5_d7d2); /* call 0x10165ecf */
            ii(0x1010_86fd, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_8702, 5); mov(eax, 0x101c_3fc8);                  /* mov eax, 0x101c3fc8 */
            ii(0x1010_8707, 5); calld(Definitions.sys_strcpy, 0x5_d7c3); /* call 0x10165ecf */
            ii(0x1010_870c, 5); mov(edx, StringDefinitions.L3);         /* mov edx, 0x101a4534 */
            ii(0x1010_8711, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8715, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_8718, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_871b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_871d, 5); calld(Definitions.sys_strstr, 0x7_08ee); /* call 0x10179010 */
            ii(0x1010_8722, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8724, 2); if(jnzd(0x1010_8740, 0x1a)) goto l_0x1010_8740; /* jnz 0x10108740 */
            ii(0x1010_8726, 5); mov(edx, StringDefinitions.F);          /* mov edx, 0x101a4537 */
            ii(0x1010_872b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_872f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_8732, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_8735, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_8737, 5); calld(Definitions.sys_strstr, 0x7_08d4); /* call 0x10179010 */
            ii(0x1010_873c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_873e, 2); if(jzd(0x1010_874f, 0xf)) goto l_0x1010_874f; /* jz 0x1010874f */
        l_0x1010_8740:
            ii(0x1010_8740, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_8745, 5); mov(eax, 0x101c_402c);                  /* mov eax, 0x101c402c */
            ii(0x1010_874a, 5); calld(Definitions.sys_strcpy, 0x5_d780); /* call 0x10165ecf */
        l_0x1010_874f:
            ii(0x1010_874f, 5); mov(edx, StringDefinitions.F2);         /* mov edx, 0x101a453a */
            ii(0x1010_8754, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_8758, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_875b, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1010_875e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_8760, 5); calld(Definitions.sys_strstr, 0x7_08ab); /* call 0x10179010 */
            ii(0x1010_8765, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8767, 2); if(jzd(0x1010_8787, 0x1e)) goto l_0x1010_8787; /* jz 0x10108787 */
            ii(0x1010_8769, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_876e, 5); mov(eax, 0x101c_3e9c);                  /* mov eax, 0x101c3e9c */
            ii(0x1010_8773, 5); calld(Definitions.sys_strcpy, 0x5_d757); /* call 0x10165ecf */
            ii(0x1010_8778, 5); mov(edx, 0x101c_3d70);                  /* mov edx, 0x101c3d70 */
            ii(0x1010_877d, 5); mov(eax, 0x101c_3f00);                  /* mov eax, 0x101c3f00 */
            ii(0x1010_8782, 5); calld(Definitions.sys_strcpy, 0x5_d748); /* call 0x10165ecf */
        l_0x1010_8787:
            ii(0x1010_8787, 5); jmpd(0x1010_8484, -0x308); goto l_0x1010_8484; /* jmp 0x10108484 */
        l_0x1010_878c:
            ii(0x1010_878c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_878e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_878f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8790, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8791, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_8792, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_8793, 1); retd();                                 /* ret */
        }
    }
}
