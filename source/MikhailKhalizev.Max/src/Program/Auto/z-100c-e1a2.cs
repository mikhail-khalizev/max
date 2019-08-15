using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0772b238-2891-41f4-8ac3-b2004567338f")]
        public void Method_100c_e1a2()
        {
            ii(0x100c_e1a2, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100c_e1a7, 5); calld(Definitions.sys_check_available_stack_size, 0x9_7ba6); /* call 0x10165d52 */
            ii(0x100c_e1ac, 1); pushd(esi);                             /* push esi */
            ii(0x100c_e1ad, 1); pushd(edi);                             /* push edi */
            ii(0x100c_e1ae, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_e1af, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e1b1, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100c_e1b7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_e1ba, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_e1bd, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_e1c0, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100c_e1c3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_e1c7, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100c_e1ca, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x100c_e1cf, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_e1d1, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x100c_e1d4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e1d7, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100c_e1da, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_e1dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e1e0, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100c_e1e3, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_e1e6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_e1e8, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_e1eb, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x100c_e1ee, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_e1f1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_e1f4, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x100c_e1f8, 2); if(jzd(0x100c_e206, 0xc)) goto l_0x100c_e206; /* jz 0x100ce206 */
            ii(0x100c_e1fa, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x100c_e201, 5); jmpd(0x100c_e2f3, 0xed); goto l_0x100c_e2f3; /* jmp 0x100ce2f3 */
        l_0x100c_e206:
            ii(0x100c_e206, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_e209, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x100c_e20e, 5); calld(0x1010_3752, 0x3_553f);           /* call 0x10103752 */
            ii(0x100c_e213, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100c_e216, 3); test(memb_a32[ds, eax], 0x10);          /* test byte [eax], 0x10 */
            ii(0x100c_e219, 6); if(jzd(0x100c_e2b5, 0x96)) goto l_0x100c_e2b5; /* jz 0x100ce2b5 */
            ii(0x100c_e21f, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
            ii(0x100c_e226, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e229, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100c_e22c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e22f, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_e232, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_e236, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_e23a, 5); calld(0x100c_e099, -0x1a6);             /* call 0x100ce099 */
            ii(0x100c_e23f, 2); test(al, al);                           /* test al, al */
            ii(0x100c_e241, 2); if(jnzd(0x100c_e2b3, 0x70)) goto l_0x100c_e2b3; /* jnz 0x100ce2b3 */
            ii(0x100c_e243, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e246, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x100c_e249, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e24c, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100c_e24f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e252, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_e255, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_e259, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_e25d, 5); calld(0x100c_e099, -0x1c9);             /* call 0x100ce099 */
            ii(0x100c_e262, 2); test(al, al);                           /* test al, al */
            ii(0x100c_e264, 2); if(jnzd(0x100c_e2b3, 0x4d)) goto l_0x100c_e2b3; /* jnz 0x100ce2b3 */
            ii(0x100c_e266, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e269, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100c_e26c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e26f, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x100c_e272, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e275, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_e278, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_e27c, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_e280, 5); calld(0x100c_e099, -0x1ec);             /* call 0x100ce099 */
            ii(0x100c_e285, 2); test(al, al);                           /* test al, al */
            ii(0x100c_e287, 2); if(jnzd(0x100c_e2b3, 0x2a)) goto l_0x100c_e2b3; /* jnz 0x100ce2b3 */
            ii(0x100c_e289, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e28c, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x100c_e28f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e292, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100c_e295, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e298, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_e29b, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_e29f, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_e2a3, 5); calld(0x100c_e099, -0x20f);             /* call 0x100ce099 */
            ii(0x100c_e2a8, 2); test(al, al);                           /* test al, al */
            ii(0x100c_e2aa, 2); if(jnzd(0x100c_e2b3, 0x7)) goto l_0x100c_e2b3; /* jnz 0x100ce2b3 */
            ii(0x100c_e2ac, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x100c_e2b3:
            ii(0x100c_e2b3, 2); jmpd(0x100c_e2d7, 0x22); goto l_0x100c_e2d7; /* jmp 0x100ce2d7 */
        l_0x100c_e2b5:
            ii(0x100c_e2b5, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100c_e2ba, 1); pushd(eax);                             /* push eax */
            ii(0x100c_e2bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_e2be, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100c_e2c1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_e2c4, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_e2c7, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100c_e2cb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_e2cf, 5); calld(0x1007_02b9, -0x5_e01b);          /* call 0x100702b9 */
            ii(0x100c_e2d4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x100c_e2d7:
            ii(0x100c_e2d7, 5); calld(0x100d_53f0, 0x7114);             /* call 0x100d53f0 */
            ii(0x100c_e2dc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_e2de, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_e2e0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100c_e2e3, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x100c_e2e8, 5); calld(0x1010_346f, 0x3_5182);           /* call 0x1010346f */
            ii(0x100c_e2ed, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_e2f0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100c_e2f3:
            ii(0x100c_e2f3, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_e2f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e2f8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_e2f9, 1); popd(edi);                              /* pop edi */
            ii(0x100c_e2fa, 1); popd(esi);                              /* pop esi */
            ii(0x100c_e2fb, 1); retd(); return;                         /* ret */
        }
    }
}
