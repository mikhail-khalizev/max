using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1339a11c-e861-499f-9398-aebd3ce687f1")]
        public void Method_1013_f25a()
        {
            ii(0x1013_f25a, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_f25f, 5); calld(Definitions.sys_check_available_stack_size, 0x2_6aee); /* call 0x10165d52 */
            ii(0x1013_f264, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_f265, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_f266, 1); pushd(esi);                             /* push esi */
            ii(0x1013_f267, 1); pushd(edi);                             /* push edi */
            ii(0x1013_f268, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_f269, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_f26b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_f271, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_f274, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_f277, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_f27a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_f27c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1013_f27f:
            ii(0x1013_f27f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_f282, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1013_f285, 2); if(jzd(0x1013_f2b4, 0x2d)) goto l_0x1013_f2b4; /* jz 0x1013f2b4 */
            ii(0x1013_f287, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_f28a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_f28c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_f28f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_f292, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_f294, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1013_f297, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1013_f29b, 2); if(jnzd(0x1013_f2a7, 0xa)) goto l_0x1013_f2a7; /* jnz 0x1013f2a7 */
            ii(0x1013_f29d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_f2a0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1013_f2a2, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_f2a5, 2); jmpd(0x1013_f2c3, 0x1c); goto l_0x1013_f2c3; /* jmp 0x1013f2c3 */
        l_0x1013_f2a7:
            ii(0x1013_f2a7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_f2aa, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x1013_f2ad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_f2b0, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1013_f2b2, 2); jmpd(0x1013_f27f, -0x35); goto l_0x1013_f27f; /* jmp 0x1013f27f */
        l_0x1013_f2b4:
            ii(0x1013_f2b4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_f2b7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_f2ba, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1013_f2bc, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1013_f2c3:
            ii(0x1013_f2c3, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_f2c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_f2c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_f2c9, 1); popd(edi);                              /* pop edi */
            ii(0x1013_f2ca, 1); popd(esi);                              /* pop esi */
            ii(0x1013_f2cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_f2cc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_f2cd, 1); retd(); return;                         /* ret */
        }
    }
}
