using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5fbe993-bb20-4fde-8370-ae2e8fd01b65")]
        public void Method_1011_2cdd()
        {
            ii(0x1011_2cdd, 5); pushd(0xb0);                            /* push 0xb0 */
            ii(0x1011_2ce2, 5); calld(Definitions.sys_check_available_stack_size, 0x5306b); /* call 0x10165d52 */
            ii(0x1011_2ce7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_2ce8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_2ce9, 1); pushd(edx);                             /* push edx */
            ii(0x1011_2cea, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2ceb, 1); pushd(edi);                             /* push edi */
            ii(0x1011_2cec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_2ced, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_2cef, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x1011_2cf5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_2cf8, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1011_2cff, 7); mov(memd_a32[ss, ebp - 0xc], 0xa);      /* mov dword [ebp-0xc], 0xa */
            ii(0x1011_2d06, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2d09, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_2d0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2d0e, 6); mov(eax, memd_a32[ds, eax + 0x5a5]);    /* mov eax, [eax+0x5a5] */
            ii(0x1011_2d14, 5); calld(0x100d_7f6c, -0x3adad);           /* call 0x100d7f6c */
            ii(0x1011_2d19, 5); mov(edx, StringDefinitions.GameSetup);  /* mov edx, 0x101a4726 */
            ii(0x1011_2d1e, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2d21, 5); calld(Definitions.sys_strcpy, 0x531a9); /* call 0x10165ecf */
            ii(0x1011_2d26, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_2d2b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2d2c, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2d30, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2d33, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2d36, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2d39, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2d3c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2d3f, 5); calld(0x1011_2c46, -0xfe);              /* call 0x10112c46 */
            ii(0x1011_2d44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2d47, 7); cmp(memb_a32[ds, eax + 0x51f], 0);      /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_2d4e, 6); if(jzd(0x1011_2dd0, 0x7c)) goto l_0x1011_2dd0; /* jz 0x10112dd0 */
            ii(0x1011_2d54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2d57, 6); mov(al, memb_a32[ds, eax + 0x50e]);     /* mov al, [eax+0x50e] */
            ii(0x1011_2d5d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2d62, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_2d65, 6); pushd(memd_a32[ds, eax + 0x101b_9794]); /* push dword [eax+0x101b9794] */
            ii(0x1011_2d6b, 5); mov(eax, StringDefinitions.MapS);       /* mov eax, 0x101a4732 */
            ii(0x1011_2d70, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2d71, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2d74, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2d75, 5); calld(Definitions.sys_sprintf, 0x53187); /* call 0x10165f01 */
            ii(0x1011_2d7a, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2d7d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2d7f, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2d80, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2d84, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2d87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2d8a, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2d8d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2d90, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2d93, 5); calld(0x1011_2c46, -0x152);             /* call 0x10112c46 */
            ii(0x1011_2d98, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2d9b, 5); add(eax, 0x4f0);                        /* add eax, 0x4f0 */
            ii(0x1011_2da0, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2da1, 5); mov(eax, StringDefinitions.FileS);      /* mov eax, 0x101a473a */
            ii(0x1011_2da6, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2da7, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2daa, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2dab, 5); calld(Definitions.sys_sprintf, 0x53151); /* call 0x10165f01 */
            ii(0x1011_2db0, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2db3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2db5, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2db6, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2dba, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2dbd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2dc0, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2dc3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2dc6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2dc9, 5); calld(0x1011_2c46, -0x188);             /* call 0x10112c46 */
            ii(0x1011_2dce, 2); jmpd(0x1011_2e39, 0x69); goto l_0x1011_2e39; /* jmp 0x10112e39 */
        l_0x1011_2dd0:
            ii(0x1011_2dd0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2dd3, 5); add(eax, 0x4f0);                        /* add eax, 0x4f0 */
            ii(0x1011_2dd8, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2dd9, 5); mov(eax, StringDefinitions.MapS2);      /* mov eax, 0x101a4743 */
            ii(0x1011_2dde, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2ddf, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2de2, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2de3, 5); calld(Definitions.sys_sprintf, 0x53119); /* call 0x10165f01 */
            ii(0x1011_2de8, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2deb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2ded, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2dee, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2df2, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2df5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2df8, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2dfb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2dfe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2e01, 5); calld(0x1011_2c46, -0x1c0);             /* call 0x10112c46 */
            ii(0x1011_2e06, 5); mov(eax, StringDefinitions.Empty13);    /* mov eax, 0x101a474b */
            ii(0x1011_2e0b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2e0c, 5); mov(eax, StringDefinitions.FileS2);     /* mov eax, 0x101a474c */
            ii(0x1011_2e11, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2e12, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2e15, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2e16, 5); calld(Definitions.sys_sprintf, 0x530e6); /* call 0x10165f01 */
            ii(0x1011_2e1b, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2e1e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2e20, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2e21, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2e25, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2e28, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2e2b, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2e2e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2e31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2e34, 5); calld(0x1011_2c46, -0x1f3);             /* call 0x10112c46 */
        l_0x1011_2e39:
            ii(0x1011_2e39, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2e3c, 7); cmp(memb_a32[ds, eax + 0x50f], 0);      /* cmp byte [eax+0x50f], 0x0 */
            ii(0x1011_2e43, 2); if(jzd(0x1011_2e4e, 0x9)) goto l_0x1011_2e4e; /* jz 0x10112e4e */
            ii(0x1011_2e45, 7); mov(memd_a32[ss, ebp - 0x6c], StringDefinitions.Simultaneous); /* mov dword [ebp-0x6c], 0x101a4755 */
            ii(0x1011_2e4c, 2); jmpd(0x1011_2e55, 0x7); goto l_0x1011_2e55; /* jmp 0x10112e55 */
        l_0x1011_2e4e:
            ii(0x1011_2e4e, 7); mov(memd_a32[ss, ebp - 0x6c], StringDefinitions.TurnBased); /* mov dword [ebp-0x6c], 0x101a4762 */
        l_0x1011_2e55:
            ii(0x1011_2e55, 3); pushd(memd_a32[ss, ebp - 0x6c]);        /* push dword [ebp-0x6c] */
            ii(0x1011_2e58, 5); mov(eax, StringDefinitions.PlayModeS);  /* mov eax, 0x101a476d */
            ii(0x1011_2e5d, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2e5e, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2e61, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2e62, 5); calld(Definitions.sys_sprintf, 0x5309a); /* call 0x10165f01 */
            ii(0x1011_2e67, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2e6a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2e6c, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2e6d, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2e71, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2e74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2e77, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2e7a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2e7d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2e80, 5); calld(0x1011_2c46, -0x23f);             /* call 0x10112c46 */
            ii(0x1011_2e85, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1011_2e8a, 3); lea(edx, ebp - 0x78);                   /* lea edx, [ebp-0x78] */
            ii(0x1011_2e8d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2e90, 6); mov(eax, memd_a32[ds, eax + 0x50e]);    /* mov eax, [eax+0x50e] */
            ii(0x1011_2e96, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_2e99, 5); calld(/* sys */ 0x1017_93f8, 0x6655a);  /* call 0x101793f8 */
            ii(0x1011_2e9e, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1011_2ea3, 6); lea(edx, ebp - 0x84);                   /* lea edx, [ebp-0x84] */
            ii(0x1011_2ea9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2eac, 6); mov(eax, memd_a32[ds, eax + 0x510]);    /* mov eax, [eax+0x510] */
            ii(0x1011_2eb2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_2eb5, 5); calld(/* sys */ 0x1017_93f8, 0x6653e);  /* call 0x101793f8 */
            ii(0x1011_2eba, 6); lea(eax, ebp - 0x84);                   /* lea eax, [ebp-0x84] */
            ii(0x1011_2ec0, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2ec1, 3); lea(eax, ebp - 0x78);                   /* lea eax, [ebp-0x78] */
            ii(0x1011_2ec4, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2ec5, 5); mov(eax, StringDefinitions.TurnTimeSEndTurnS); /* mov eax, 0x101a477b */
            ii(0x1011_2eca, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2ecb, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2ece, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2ecf, 5); calld(Definitions.sys_sprintf, 0x5302d); /* call 0x10165f01 */
            ii(0x1011_2ed4, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1011_2ed7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2ed9, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2eda, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2ede, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2ee1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2ee4, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2ee7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2eea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2eed, 5); calld(0x1011_2c46, -0x2ac);             /* call 0x10112c46 */
            ii(0x1011_2ef2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2ef5, 6); mov(eax, memd_a32[ds, eax + 0x513]);    /* mov eax, [eax+0x513] */
            ii(0x1011_2efb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_2efe, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2eff, 5); mov(eax, StringDefinitions.StartingCreditI); /* mov eax, 0x101a4798 */
            ii(0x1011_2f04, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f05, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2f08, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f09, 5); calld(Definitions.sys_sprintf, 0x52ff3); /* call 0x10165f01 */
            ii(0x1011_2f0e, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2f11, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2f13, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f14, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2f18, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2f1b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2f1e, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2f21, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2f24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2f27, 5); calld(0x1011_2c46, -0x2e6);             /* call 0x10112c46 */
            ii(0x1011_2f2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2f2f, 6); mov(al, memb_a32[ds, eax + 0x517]);     /* mov al, [eax+0x517] */
            ii(0x1011_2f35, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2f3a, 3); add(eax, 0x2f);                         /* add eax, 0x2f */
            ii(0x1011_2f3d, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1011_2f40, 6); pushd(memd_a32[ds, eax + 0x101b_a5bc]); /* push dword [eax+0x101ba5bc] */
            ii(0x1011_2f46, 5); mov(eax, StringDefinitions.RawResourcesS); /* mov eax, 0x101a47ac */
            ii(0x1011_2f4b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f4c, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2f4f, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f50, 5); calld(Definitions.sys_sprintf, 0x52fac); /* call 0x10165f01 */
            ii(0x1011_2f55, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2f58, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2f5a, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f5b, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2f5f, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2f62, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2f65, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2f68, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2f6b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2f6e, 5); calld(0x1011_2c46, -0x32d);             /* call 0x10112c46 */
            ii(0x1011_2f73, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_2f76, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2f78, 6); mov(al, memb_a32[ds, edx + 0x518]);     /* mov al, [edx+0x518] */
            ii(0x1011_2f7e, 3); add(eax, 0x32);                         /* add eax, 0x32 */
            ii(0x1011_2f81, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1011_2f84, 6); pushd(memd_a32[ds, eax + 0x101b_a5bc]); /* push dword [eax+0x101ba5bc] */
            ii(0x1011_2f8a, 5); mov(eax, StringDefinitions.FuelResourcesS); /* mov eax, 0x101a47be */
            ii(0x1011_2f8f, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f90, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2f93, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f94, 5); calld(Definitions.sys_sprintf, 0x52f68); /* call 0x10165f01 */
            ii(0x1011_2f99, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2f9c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2f9e, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2f9f, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2fa3, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2fa6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2fa9, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2fac, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2faf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2fb2, 5); calld(0x1011_2c46, -0x371);             /* call 0x10112c46 */
            ii(0x1011_2fb7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_2fba, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2fbc, 6); mov(al, memb_a32[ds, edx + 0x519]);     /* mov al, [edx+0x519] */
            ii(0x1011_2fc2, 3); add(eax, 0x35);                         /* add eax, 0x35 */
            ii(0x1011_2fc5, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1011_2fc8, 6); pushd(memd_a32[ds, eax + 0x101b_a5bc]); /* push dword [eax+0x101ba5bc] */
            ii(0x1011_2fce, 5); mov(eax, StringDefinitions.GoldResourcesS); /* mov eax, 0x101a47d1 */
            ii(0x1011_2fd3, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2fd4, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_2fd7, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2fd8, 5); calld(Definitions.sys_sprintf, 0x52f24); /* call 0x10165f01 */
            ii(0x1011_2fdd, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_2fe0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2fe2, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2fe3, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_2fe7, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_2fea, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2fed, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_2ff0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_2ff3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_2ff6, 5); calld(0x1011_2c46, -0x3b5);             /* call 0x10112c46 */
            ii(0x1011_2ffb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_2ffe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3000, 6); mov(al, memb_a32[ds, edx + 0x51a]);     /* mov al, [edx+0x51a] */
            ii(0x1011_3006, 3); add(eax, 0x38);                         /* add eax, 0x38 */
            ii(0x1011_3009, 3); imul(eax, eax, 0x14);                   /* imul eax, eax, 0x14 */
            ii(0x1011_300c, 6); pushd(memd_a32[ds, eax + 0x101b_a5bc]); /* push dword [eax+0x101ba5bc] */
            ii(0x1011_3012, 5); mov(eax, StringDefinitions.AlienDerelictsS); /* mov eax, 0x101a47e4 */
            ii(0x1011_3017, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3018, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_301b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_301c, 5); calld(Definitions.sys_sprintf, 0x52ee0); /* call 0x10165f01 */
            ii(0x1011_3021, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_3024, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3026, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3027, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_302b, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_302e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3031, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_3034, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_3037, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_303a, 5); calld(0x1011_2c46, -0x3f9);             /* call 0x10112c46 */
            ii(0x1011_303f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3042, 6); mov(eax, memd_a32[ds, eax + 0x51a]);    /* mov eax, [eax+0x51a] */
            ii(0x1011_3048, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_304b, 1); pushd(eax);                             /* push eax */
            ii(0x1011_304c, 5); mov(eax, StringDefinitions.VictoryI);   /* mov eax, 0x101a47f8 */
            ii(0x1011_3051, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3052, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_3055, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3056, 5); calld(Definitions.sys_sprintf, 0x52ea6); /* call 0x10165f01 */
            ii(0x1011_305b, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1011_305e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3061, 6); mov(al, memb_a32[ds, eax + 0x51b]);     /* mov al, [eax+0x51b] */
            ii(0x1011_3067, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_306c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_306e, 2); if(jnzd(0x1011_307f, 0xf)) goto l_0x1011_307f; /* jnz 0x1011307f */
            ii(0x1011_3070, 5); mov(edx, StringDefinitions.Turns);      /* mov edx, 0x101a4805 */
            ii(0x1011_3075, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_3078, 5); calld(Definitions.sys_strcat, 0x52eb4); /* call 0x10165f31 */
            ii(0x1011_307d, 2); jmpd(0x1011_308c, 0xd); goto l_0x1011_308c; /* jmp 0x1011308c */
        l_0x1011_307f:
            ii(0x1011_307f, 5); mov(edx, StringDefinitions.Points3);    /* mov edx, 0x101a480b */
            ii(0x1011_3084, 3); lea(eax, ebp - 0x68);                   /* lea eax, [ebp-0x68] */
            ii(0x1011_3087, 5); calld(Definitions.sys_strcat, 0x52ea5); /* call 0x10165f31 */
        l_0x1011_308c:
            ii(0x1011_308c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_308e, 1); pushd(eax);                             /* push eax */
            ii(0x1011_308f, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1011_3093, 3); lea(ebx, ebp - 0x68);                   /* lea ebx, [ebp-0x68] */
            ii(0x1011_3096, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3099, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1011_309c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_309f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_30a2, 5); calld(0x1011_2c46, -0x461);             /* call 0x10112c46 */
            ii(0x1011_30a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_30aa, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1011_30ae, 2); if(jzd(0x1011_30f8, 0x48)) goto l_0x1011_30f8; /* jz 0x101130f8 */
            ii(0x1011_30b0, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_30b5, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x1011_30ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_30bd, 5); calld(0x1011_285d, -0x865);             /* call 0x1011285d */
            ii(0x1011_30c2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_30c7, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1011_30cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_30cf, 5); calld(0x1011_285d, -0x877);             /* call 0x1011285d */
            ii(0x1011_30d4, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_30d9, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1011_30de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_30e1, 5); calld(0x1011_285d, -0x889);             /* call 0x1011285d */
            ii(0x1011_30e6, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_30eb, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1011_30f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_30f3, 5); calld(0x1011_285d, -0x89b);             /* call 0x1011285d */
        l_0x1011_30f8:
            ii(0x1011_30f8, 7); mov(memd_a32[ss, ebp - 0x8], 0x2);      /* mov dword [ebp-0x8], 0x2 */
            ii(0x1011_30ff, 2); jmpd(0x1011_3107, 0x6); goto l_0x1011_3107; /* jmp 0x10113107 */
        l_0x1011_3101:
            ii(0x1011_3101, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3104, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1011_3107:
            ii(0x1011_3107, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_310b, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1011_310e, 2); if(jgd(0x1011_3120, 0x10)) goto l_0x1011_3120; /* jg 0x10113120 */
            ii(0x1011_3110, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_3112, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1011_3116, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3119, 5); calld(0x1011_285d, -0x8c1);             /* call 0x1011285d */
            ii(0x1011_311e, 2); jmpd(0x1011_3101, -0x1f); goto l_0x1011_3101; /* jmp 0x10113101 */
        l_0x1011_3120:
            ii(0x1011_3120, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_3122, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_3123, 1); popd(edi);                              /* pop edi */
            ii(0x1011_3124, 1); popd(esi);                              /* pop esi */
            ii(0x1011_3125, 1); popd(edx);                              /* pop edx */
            ii(0x1011_3126, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_3127, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_3128, 1); retd(); return;                         /* ret */
        }
    }
}
