using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_189a-be0c9c07")]
        public void my_strobj_dtor()
        {
            ii(0x1014_189a, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_189f, 5); calld(Definitions.sys_check_available_stack_size, 0x2_44ae); /* call 0x10165d52 */
            ii(0x1014_18a4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_18a5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_18a6, 1); pushd(esi);                             /* push esi */
            ii(0x1014_18a7, 1); pushd(edi);                             /* push edi */
            ii(0x1014_18a8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_18a9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_18ab, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_18b1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_18b4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_18b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_18ba, 4); cmp(memd_a32[ds, eax + 0x8], 0);        /* cmp dword [eax+0x8], 0x0 */
            ii(0x1014_18be, 2); if(jnzd(0x1014_18c9, 0x9)) goto l_0x1014_18c9; /* jnz 0x101418c9 */
            ii(0x1014_18c0, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_18c7, 2); jmpd(0x1014_18e2, 0x19); goto l_0x1014_18e2; /* jmp 0x101418e2 */
        l_0x1014_18c9:
            ii(0x1014_18c9, 5); mov(ecx, 0x3f);                         /* mov ecx, 0x3f */
            ii(0x1014_18ce, 5); mov(ebx, StringDefinitions.StrobjCpp);  /* mov ebx, 0x101ace94 */
            ii(0x1014_18d3, 5); mov(edx, StringDefinitions.RefCountEqual0); /* mov edx, 0x101ace9f */
            ii(0x1014_18d8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_18da, 5); calld(Definitions.sys_assert, 0x2_44b3); /* call 0x10165d92 */
            ii(0x1014_18df, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x1014_18e2:
            ii(0x1014_18e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_18e5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_18e7, 5); calld(Definitions.sys_delete_arr, 0x2_46ec); /* call 0x10165fd8 */
            ii(0x1014_18ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_18ef, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_18f2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_18f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_18f7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_18f8, 1); popd(edi);                              /* pop edi */
            ii(0x1014_18f9, 1); popd(esi);                              /* pop esi */
            ii(0x1014_18fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_18fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_18fc, 1); retd(); return;                         /* ret */
        }
    }
}
