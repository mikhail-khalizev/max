using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_c0bb-b2bf4a1a")]
        public void Method_1014_c0bb()
        {
            ii(0x1014_c0bb, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_c0c0, 5); calld(Definitions.sys_check_available_stack_size, 0x1_9c8d); /* call 0x10165d52 */
            ii(0x1014_c0c5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_c0c6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_c0c7, 1); pushd(edx);                             /* push edx */
            ii(0x1014_c0c8, 1); pushd(esi);                             /* push esi */
            ii(0x1014_c0c9, 1); pushd(edi);                             /* push edi */
            ii(0x1014_c0ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_c0cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_c0cd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_c0d3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_c0d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c0d9, 4); test(memb_a32[ds, eax + 0x69], 0x1);    /* test byte [eax+0x69], 0x1 */
            ii(0x1014_c0dd, 2); if(jzd(0x1014_c10b, 0x2c)) goto l_0x1014_c10b; /* jz 0x1014c10b */
            ii(0x1014_c0df, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_c0e4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c0e7, 5); calld(0x1014_b7be, -0x92e);             /* call 0x1014b7be */
            ii(0x1014_c0ec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c0ef, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c0f3, 2); if(jzd(0x1014_c0fe, 0x9)) goto l_0x1014_c0fe; /* jz 0x1014c0fe */
            ii(0x1014_c0f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c0f8, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c0fc, 2); if(jzd(0x1014_c100, 0x2)) goto l_0x1014_c100; /* jz 0x1014c100 */
        l_0x1014_c0fe:
            ii(0x1014_c0fe, 2); jmpd(0x1014_c10b, 0xb); goto l_0x1014_c10b; /* jmp 0x1014c10b */
        l_0x1014_c100:
            ii(0x1014_c100, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c103, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c106, 5); jmpd(0x1014_c27f, 0x174); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c10b:
            ii(0x1014_c10b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c10e, 4); test(memb_a32[ds, eax + 0x69], 0x2);    /* test byte [eax+0x69], 0x2 */
            ii(0x1014_c112, 2); if(jzd(0x1014_c140, 0x2c)) goto l_0x1014_c140; /* jz 0x1014c140 */
            ii(0x1014_c114, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1014_c119, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c11c, 5); calld(0x1014_b7be, -0x963);             /* call 0x1014b7be */
            ii(0x1014_c121, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c124, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c128, 2); if(jzd(0x1014_c133, 0x9)) goto l_0x1014_c133; /* jz 0x1014c133 */
            ii(0x1014_c12a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c12d, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c131, 2); if(jzd(0x1014_c135, 0x2)) goto l_0x1014_c135; /* jz 0x1014c135 */
        l_0x1014_c133:
            ii(0x1014_c133, 2); jmpd(0x1014_c140, 0xb); goto l_0x1014_c140; /* jmp 0x1014c140 */
        l_0x1014_c135:
            ii(0x1014_c135, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c138, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c13b, 5); jmpd(0x1014_c27f, 0x13f); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c140:
            ii(0x1014_c140, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c143, 4); test(memb_a32[ds, eax + 0x69], 0x4);    /* test byte [eax+0x69], 0x4 */
            ii(0x1014_c147, 2); if(jzd(0x1014_c175, 0x2c)) goto l_0x1014_c175; /* jz 0x1014c175 */
            ii(0x1014_c149, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1014_c14e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c151, 5); calld(0x1014_b7be, -0x998);             /* call 0x1014b7be */
            ii(0x1014_c156, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c159, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c15d, 2); if(jzd(0x1014_c168, 0x9)) goto l_0x1014_c168; /* jz 0x1014c168 */
            ii(0x1014_c15f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c162, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c166, 2); if(jzd(0x1014_c16a, 0x2)) goto l_0x1014_c16a; /* jz 0x1014c16a */
        l_0x1014_c168:
            ii(0x1014_c168, 2); jmpd(0x1014_c175, 0xb); goto l_0x1014_c175; /* jmp 0x1014c175 */
        l_0x1014_c16a:
            ii(0x1014_c16a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c16d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c170, 5); jmpd(0x1014_c27f, 0x10a); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c175:
            ii(0x1014_c175, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c178, 4); test(memb_a32[ds, eax + 0x69], 0x8);    /* test byte [eax+0x69], 0x8 */
            ii(0x1014_c17c, 2); if(jzd(0x1014_c1aa, 0x2c)) goto l_0x1014_c1aa; /* jz 0x1014c1aa */
            ii(0x1014_c17e, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1014_c183, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c186, 5); calld(0x1014_b7be, -0x9cd);             /* call 0x1014b7be */
            ii(0x1014_c18b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c18e, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c192, 2); if(jzd(0x1014_c19d, 0x9)) goto l_0x1014_c19d; /* jz 0x1014c19d */
            ii(0x1014_c194, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c197, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c19b, 2); if(jzd(0x1014_c19f, 0x2)) goto l_0x1014_c19f; /* jz 0x1014c19f */
        l_0x1014_c19d:
            ii(0x1014_c19d, 2); jmpd(0x1014_c1aa, 0xb); goto l_0x1014_c1aa; /* jmp 0x1014c1aa */
        l_0x1014_c19f:
            ii(0x1014_c19f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c1a2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c1a5, 5); jmpd(0x1014_c27f, 0xd5); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c1aa:
            ii(0x1014_c1aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c1ad, 4); test(memb_a32[ds, eax + 0x69], 0x20);   /* test byte [eax+0x69], 0x20 */
            ii(0x1014_c1b1, 2); if(jzd(0x1014_c1df, 0x2c)) goto l_0x1014_c1df; /* jz 0x1014c1df */
            ii(0x1014_c1b3, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_c1b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c1bb, 5); calld(0x1014_b7be, -0xa02);             /* call 0x1014b7be */
            ii(0x1014_c1c0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c1c3, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c1c7, 2); if(jzd(0x1014_c1d2, 0x9)) goto l_0x1014_c1d2; /* jz 0x1014c1d2 */
            ii(0x1014_c1c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c1cc, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c1d0, 2); if(jzd(0x1014_c1d4, 0x2)) goto l_0x1014_c1d4; /* jz 0x1014c1d4 */
        l_0x1014_c1d2:
            ii(0x1014_c1d2, 2); jmpd(0x1014_c1df, 0xb); goto l_0x1014_c1df; /* jmp 0x1014c1df */
        l_0x1014_c1d4:
            ii(0x1014_c1d4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c1d7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c1da, 5); jmpd(0x1014_c27f, 0xa0); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c1df:
            ii(0x1014_c1df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c1e2, 4); test(memb_a32[ds, eax + 0x69], 0x10);   /* test byte [eax+0x69], 0x10 */
            ii(0x1014_c1e6, 2); if(jzd(0x1014_c214, 0x2c)) goto l_0x1014_c214; /* jz 0x1014c214 */
            ii(0x1014_c1e8, 5); mov(edx, 0x10);                         /* mov edx, 0x10 */
            ii(0x1014_c1ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c1f0, 5); calld(0x1014_b7be, -0xa37);             /* call 0x1014b7be */
            ii(0x1014_c1f5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c1f8, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c1fc, 2); if(jzd(0x1014_c207, 0x9)) goto l_0x1014_c207; /* jz 0x1014c207 */
            ii(0x1014_c1fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c201, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c205, 2); if(jzd(0x1014_c209, 0x2)) goto l_0x1014_c209; /* jz 0x1014c209 */
        l_0x1014_c207:
            ii(0x1014_c207, 2); jmpd(0x1014_c214, 0xb); goto l_0x1014_c214; /* jmp 0x1014c214 */
        l_0x1014_c209:
            ii(0x1014_c209, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c20c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c20f, 5); jmpd(0x1014_c27f, 0x6b); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c214:
            ii(0x1014_c214, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c217, 4); test(memb_a32[ds, eax + 0x69], 0x80);   /* test byte [eax+0x69], 0x80 */
            ii(0x1014_c21b, 2); if(jzd(0x1014_c246, 0x29)) goto l_0x1014_c246; /* jz 0x1014c246 */
            ii(0x1014_c21d, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_c222, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c225, 5); calld(0x1014_b7be, -0xa6c);             /* call 0x1014b7be */
            ii(0x1014_c22a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c22d, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c231, 2); if(jzd(0x1014_c23c, 0x9)) goto l_0x1014_c23c; /* jz 0x1014c23c */
            ii(0x1014_c233, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c236, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c23a, 2); if(jzd(0x1014_c23e, 0x2)) goto l_0x1014_c23e; /* jz 0x1014c23e */
        l_0x1014_c23c:
            ii(0x1014_c23c, 2); jmpd(0x1014_c246, 0x8); goto l_0x1014_c246; /* jmp 0x1014c246 */
        l_0x1014_c23e:
            ii(0x1014_c23e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c241, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c244, 2); jmpd(0x1014_c27f, 0x39); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c246:
            ii(0x1014_c246, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c249, 4); test(memb_a32[ds, eax + 0x69], 0x40);   /* test byte [eax+0x69], 0x40 */
            ii(0x1014_c24d, 2); if(jzd(0x1014_c278, 0x29)) goto l_0x1014_c278; /* jz 0x1014c278 */
            ii(0x1014_c24f, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x1014_c254, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_c257, 5); calld(0x1014_b7be, -0xa9e);             /* call 0x1014b7be */
            ii(0x1014_c25c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_c25f, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_c263, 2); if(jzd(0x1014_c26e, 0x9)) goto l_0x1014_c26e; /* jz 0x1014c26e */
            ii(0x1014_c265, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c268, 4); test(memb_a32[ds, eax + 0x6a], 0x4);    /* test byte [eax+0x6a], 0x4 */
            ii(0x1014_c26c, 2); if(jzd(0x1014_c270, 0x2)) goto l_0x1014_c270; /* jz 0x1014c270 */
        l_0x1014_c26e:
            ii(0x1014_c26e, 2); jmpd(0x1014_c278, 0x8); goto l_0x1014_c278; /* jmp 0x1014c278 */
        l_0x1014_c270:
            ii(0x1014_c270, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_c273, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_c276, 2); jmpd(0x1014_c27f, 0x7); goto l_0x1014_c27f; /* jmp 0x1014c27f */
        l_0x1014_c278:
            ii(0x1014_c278, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1014_c27f:
            ii(0x1014_c27f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_c282, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_c284, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_c285, 1); popd(edi);                              /* pop edi */
            ii(0x1014_c286, 1); popd(esi);                              /* pop esi */
            ii(0x1014_c287, 1); popd(edx);                              /* pop edx */
            ii(0x1014_c288, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_c289, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_c28a, 1); retd();                                 /* ret */
        }
    }
}
