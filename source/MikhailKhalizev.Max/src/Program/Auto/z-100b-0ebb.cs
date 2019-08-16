using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("272e18d5-0304-4217-b70d-aa4e42d31106")]
        public void Method_100b_0ebb()
        {
            ii(0x100b_0ebb, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_0ec0, 5); calld(Definitions.sys_check_available_stack_size, 0xb_4e8d); /* call 0x10165d52 */
            ii(0x100b_0ec5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0ec6, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0ec7, 1); pushd(edi);                             /* push edi */
            ii(0x100b_0ec8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_0ec9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0ecb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_0ed1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_0ed4, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_0ed7, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100b_0eda, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_0ede, 2); if(jnzd(0x100b_0f06, 0x26)) goto l_0x100b_0f06; /* jnz 0x100b0f06 */
            ii(0x100b_0ee0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0ee3, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100b_0ee6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_0eeb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_0eed, 2); if(jled(0x100b_0ef5, 0x6)) goto l_0x100b_0ef5; /* jle 0x100b0ef5 */
            ii(0x100b_0eef, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100b_0ef3, 2); jmpd(0x100b_0ef9, 0x4); goto l_0x100b_0ef9; /* jmp 0x100b0ef9 */
        l_0x100b_0ef5:
            ii(0x100b_0ef5, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100b_0ef9:
            ii(0x100b_0ef9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0efb, 3); mov(dl, memb_a32[ss, ebp - 0x10]);      /* mov dl, [ebp-0x10] */
            ii(0x100b_0efe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0f01, 5); calld(0x100a_297d, -0xe589);            /* call 0x100a297d */
        l_0x100b_0f06:
            ii(0x100b_0f06, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0f08, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_0f09, 1); popd(edi);                              /* pop edi */
            ii(0x100b_0f0a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_0f0b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_0f0c, 1); retd(); return;                         /* ret */
        }
    }
}