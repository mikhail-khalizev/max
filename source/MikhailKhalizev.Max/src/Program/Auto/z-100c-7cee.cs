using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c4c2ca56-a462-48f0-a356-5cb940f4dee1")]
        public void Method_100c_7cee()
        {
            ii(0x100c_7cee, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_7cf3, 5); calld(Definitions.sys_check_available_stack_size, 0x9_e05a); /* call 0x10165d52 */
            ii(0x100c_7cf8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_7cf9, 1); pushd(esi);                             /* push esi */
            ii(0x100c_7cfa, 1); pushd(edi);                             /* push edi */
            ii(0x100c_7cfb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_7cfc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_7cfe, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_7d04, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_7d07, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_7d0a, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_7d0d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7d10, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100c_7d13, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_7d16, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7d19, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x100c_7d1c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_7d1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7d21, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_7d23, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_7d26, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100c_7d28, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_7d2a, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
        l_0x100c_7d2d:
            ii(0x100c_7d2d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7d30, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100c_7d34, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100c_7d38, 2); if(jged(0x100c_7d49, 0xf)) goto l_0x100c_7d49; /* jge 0x100c7d49 */
            ii(0x100c_7d3a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7d3d, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100c_7d3f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_7d44, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_7d47, 2); if(jnzd(0x100c_7d4b, 0x2)) goto l_0x100c_7d4b; /* jnz 0x100c7d4b */
        l_0x100c_7d49:
            ii(0x100c_7d49, 2); jmpd(0x100c_7d5a, 0xf); goto l_0x100c_7d5a; /* jmp 0x100c7d5a */
        l_0x100c_7d4b:
            ii(0x100c_7d4b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_7d4e, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x100c_7d51, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7d54, 4); inc(memw_a32[ds, eax + 0x2]);           /* inc word [eax+0x2] */
            ii(0x100c_7d58, 2); jmpd(0x100c_7d2d, -0x2d); goto l_0x100c_7d2d; /* jmp 0x100c7d2d */
        l_0x100c_7d5a:
            ii(0x100c_7d5a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7d5d, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100c_7d61, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_7d64, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_7d67, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7d69, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_7d6a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_7d6b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_7d6c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_7d6d, 1); retd(); return;                         /* ret */
        }
    }
}
