using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4c32-3279d24f")]
        public void Method_100e_4c32()
        {
            ii(0x100e_4c32, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100e_4c37, 5); calld(Definitions.sys_check_available_stack_size, 0x8_1116); /* call 0x10165d52 */
            ii(0x100e_4c3c, 1); pushd(edx);                             /* push edx */
            ii(0x100e_4c3d, 1); pushd(esi);                             /* push esi */
            ii(0x100e_4c3e, 1); pushd(edi);                             /* push edi */
            ii(0x100e_4c3f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4c40, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4c42, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100e_4c48, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_4c4b, 4); mov(memw_a32[ss, ebp - 0xc], cx);       /* mov [ebp-0xc], cx */
            ii(0x100e_4c4f, 3); mov(memd_a32[ss, ebp - 0x10], ebx);     /* mov [ebp-0x10], ebx */
            ii(0x100e_4c52, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_4c57, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4c59, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100e_4c5c, 5); calld(Definitions.sys_memset, 0x8_117f); /* call 0x10165de0 */
            ii(0x100e_4c61, 6); mov(memw_a32[ss, ebp - 0x2c], 0x205);   /* mov word [ebp-0x2c], 0x205 */
            ii(0x100e_4c67, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_4c6a, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x100e_4c6d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_4c70, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x100e_4c73, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_4c75, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_4c77, 4); mov(memw_a32[ss, ebp - 0x24], dx);      /* mov [ebp-0x24], dx */
            ii(0x100e_4c7b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_4c7e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_4c81, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x100e_4c84, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100e_4c87, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_4c8c, 5); calld(/* sys */ 0x1016_c606, 0x8_7975); /* call 0x1016c606 */
            ii(0x100e_4c91, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_4c95, 2); if(jnzd(0x100e_4ca0, 0x9)) goto l_0x100e_4ca0; /* jnz 0x100e4ca0 */
            ii(0x100e_4c97, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100e_4c9e, 2); jmpd(0x100e_4ca7, 0x7); goto l_0x100e_4ca7; /* jmp 0x100e4ca7 */
        l_0x100e_4ca0:
            ii(0x100e_4ca0, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
        l_0x100e_4ca7:
            ii(0x100e_4ca7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_4caa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4cac, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4cad, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4cae, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4caf, 1); popd(edx);                              /* pop edx */
            ii(0x100e_4cb0, 1); retd(); return;                         /* ret */
        }
    }
}
