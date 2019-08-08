using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4fb2a158-0f6b-46da-9ccf-fd786b6d6ffe")]
        public void Method_1013_b3e6()
        {
            ii(0x1013_b3e6, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1013_b3eb, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a962); /* call 0x10165d52 */
            ii(0x1013_b3f0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b3f1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b3f2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b3f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b3f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b3f6, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1013_b3fc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b3ff, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_b402, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1013_b405, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_b40c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b40f, 3); mov(eax, memd_a32[ds, eax + 0x2]);      /* mov eax, [eax+0x2] */
            ii(0x1013_b412, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_b415, 1); dec(eax);                               /* dec eax */
            ii(0x1013_b416, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1013_b419:
            ii(0x1013_b419, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b41c, 3); cmp(eax, memd_a32[ss, ebp - 0x14]);     /* cmp eax, [ebp-0x14] */
            ii(0x1013_b41f, 6); if(jgd(0x1013_b494, 0x6f)) goto l_0x1013_b494; /* jg 0x1013b494 */
            ii(0x1013_b425, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_b428, 3); add(edx, memd_a32[ss, ebp - 0x14]);     /* add edx, [ebp-0x14] */
            ii(0x1013_b42b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_b42d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_b430, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_b432, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_b434, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_b437, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b43a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_b43d, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_b440, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1013_b442, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b445, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_b448, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_b44b, 3); mov(ebx, memd_a32[ds, eax + 0xa]);      /* mov ebx, [eax+0xa] */
            ii(0x1013_b44e, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1013_b452, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b455, 5); calld(0x100a_b494, -0x8_ffc6);          /* call 0x100ab494 */
            ii(0x1013_b45a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_b45c, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_b45f, 2); calld_abs(memd_a32[ds, ebx]);           /* call dword [ebx] */
            ii(0x1013_b461, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x1013_b464, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_b466, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1013_b468, 2); calld_abs(memd_a32[ds, ecx]);           /* call dword [ecx] */
            ii(0x1013_b46a, 1); cwde();                                 /* cwde */
            ii(0x1013_b46b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_b46e, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1013_b472, 2); if(jnzd(0x1013_b47c, 0x8)) goto l_0x1013_b47c; /* jnz 0x1013b47c */
            ii(0x1013_b474, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_b477, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_b47a, 2); jmpd(0x1013_b4a9, 0x2d); goto l_0x1013_b4a9; /* jmp 0x1013b4a9 */
        l_0x1013_b47c:
            ii(0x1013_b47c, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1013_b480, 2); if(jged(0x1013_b48b, 0x9)) goto l_0x1013_b48b; /* jge 0x1013b48b */
            ii(0x1013_b482, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_b485, 1); dec(eax);                               /* dec eax */
            ii(0x1013_b486, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_b489, 2); jmpd(0x1013_b492, 0x7); goto l_0x1013_b492; /* jmp 0x1013b492 */
        l_0x1013_b48b:
            ii(0x1013_b48b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_b48e, 1); inc(eax);                               /* inc eax */
            ii(0x1013_b48f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1013_b492:
            ii(0x1013_b492, 2); jmpd(0x1013_b419, -0x7b); goto l_0x1013_b419; /* jmp 0x1013b419 */
        l_0x1013_b494:
            ii(0x1013_b494, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_b498, 2); if(jzd(0x1013_b4a3, 0x9)) goto l_0x1013_b4a3; /* jz 0x1013b4a3 */
            ii(0x1013_b49a, 7); mov(memd_a32[ss, ebp - 0x28], 0xffff_ffff); /* mov dword [ebp-0x28], 0xffffffff */
            ii(0x1013_b4a1, 2); jmpd(0x1013_b4a9, 0x6); goto l_0x1013_b4a9; /* jmp 0x1013b4a9 */
        l_0x1013_b4a3:
            ii(0x1013_b4a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_b4a6, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1013_b4a9:
            ii(0x1013_b4a9, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1013_b4ac, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b4ae, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b4af, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b4b0, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b4b1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b4b2, 1); retd(); return;                         /* ret */
        }
    }
}
