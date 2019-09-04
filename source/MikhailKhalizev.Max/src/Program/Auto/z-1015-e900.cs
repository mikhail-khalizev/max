using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_e900-d4dadcf6")]
        public void Method_1015_e900()
        {
            ii(0x1015_e900, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_e905, 5);  call(Definitions.sys_check_available_stack_size, 0x7448);/* call 0x10165d52 */
            ii(0x1015_e90a, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_e90b, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_e90c, 1);  push(edx);                            /* push edx */
            ii(0x1015_e90d, 1);  push(esi);                            /* push esi */
            ii(0x1015_e90e, 1);  push(edi);                            /* push edi */
            ii(0x1015_e90f, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_e910, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_e912, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_e918, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_e91b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e91e, 5);  call(0x1015_410e, -0xa815);           /* call 0x1015410e */
            ii(0x1015_e923, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_e925, 6);  if(jz(0x1015_ea1c, 0xf1)) goto l_0x1015_ea1c;/* jz 0x1015ea1c */
            ii(0x1015_e92b, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x1015_e930, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e933, 5);  call(0x1007_6d98, -0xe_7ba0);         /* call 0x10076d98 */
            ii(0x1015_e938, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_e93a, 2);  if(jz(0x1015_e953, 0x17)) goto l_0x1015_e953;/* jz 0x1015e953 */
            ii(0x1015_e93c, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1015_e941, 5);  mov(ebx, 0x10);                       /* mov ebx, 0x10 */
            ii(0x1015_e946, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_e949, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x1015_e94e, 5);  call(0x1013_d5c0, -0x2_1393);         /* call 0x1013d5c0 */
        l_0x1015_e953:
            ii(0x1015_e953, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e956, 5);  call(0x1007_611c, -0xe_883f);         /* call 0x1007611c */
            ii(0x1015_e95b, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x1015_e95e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_e960, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1015_e962, 5);  call(0x1007_66ac, -0xe_82bb);         /* call 0x100766ac */
            ii(0x1015_e967, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e96a, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1015_e96d, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_e970, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_e973, 3);  mov(edx, memd[ds, edx + 24]);         /* mov edx, [edx+0x18] */
            ii(0x1015_e976, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1015_e979, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1015_e97c, 5);  call(0x1007_6600, -0xe_8381);         /* call 0x10076600 */
            ii(0x1015_e981, 5);  call(0x1015_bd55, -0x2c31);           /* call 0x1015bd55 */
            ii(0x1015_e986, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1015_e989, 5);  call(0x1007_6574, -0xe_841a);         /* call 0x10076574 */
            ii(0x1015_e98e, 5);  call(0x1014_f08b, -0xf908);           /* call 0x1014f08b */
            ii(0x1015_e993, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1015_e998, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1015_e99b, 5);  call(0x1007_6600, -0xe_83a0);         /* call 0x10076600 */
            ii(0x1015_e9a0, 5);  call(0x1007_1838, -0xe_d16d);         /* call 0x10071838 */
            ii(0x1015_e9a5, 5);  mov(edx, 0x20);                       /* mov edx, 0x20 */
            ii(0x1015_e9aa, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1015_e9ad, 5);  call(0x1007_6600, -0xe_83b2);         /* call 0x10076600 */
            ii(0x1015_e9b2, 5);  call(0x1016_2f0a, 0x4553);            /* call 0x10162f0a */
            ii(0x1015_e9b7, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1015_e9ba, 5);  call(0x1007_6574, -0xe_844b);         /* call 0x10076574 */
            ii(0x1015_e9bf, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1015_e9c2, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_e9c7, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1015_e9cd, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_e9d3, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_e9d8, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1015_e9db, 2);  if(jnz(0x1015_e9e4, 7)) goto l_0x1015_e9e4;/* jnz 0x1015e9e4 */
            ii(0x1015_e9dd, 7);  mov(memb[ds, 0x101c_391b], 1);        /* mov byte [0x101c391b], 0x1 */
        l_0x1015_e9e4:
            ii(0x1015_e9e4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e9e7, 4);  dec(memw[ds, eax + 82]);              /* dec word [eax+0x52] */
            ii(0x1015_e9eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e9ee, 4);  mov(memb[ds, eax + 94], 0);           /* mov byte [eax+0x5e], 0x0 */
            ii(0x1015_e9f2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_e9f5, 4);  mov(memb[ds, eax + 62], 0x12);        /* mov byte [eax+0x3e], 0x12 */
            ii(0x1015_e9f9, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x1015_e9fe, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ea01, 5);  call(0x1007_6d98, -0xe_7c6e);         /* call 0x10076d98 */
            ii(0x1015_ea06, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_ea08, 2);  if(jz(0x1015_ea12, 8)) goto l_0x1015_ea12;/* jz 0x1015ea12 */
            ii(0x1015_ea0a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ea0d, 5);  call(0x1010_094d, -0x5_e0c5);         /* call 0x1010094d */
        l_0x1015_ea12:
            ii(0x1015_ea12, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_ea14, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1015_ea17, 5);  call(0x1007_5f2c, -0xe_8af0);         /* call 0x10075f2c */
        l_0x1015_ea1c:
            ii(0x1015_ea1c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_ea1e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_ea1f, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_ea20, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_ea21, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_ea22, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_ea23, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_ea24, 1);  ret();                                /* ret */
        }
    }
}
