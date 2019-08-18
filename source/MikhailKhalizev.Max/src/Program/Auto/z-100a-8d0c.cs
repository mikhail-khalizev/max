using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d5c7b1f4-b498-4195-bad1-237598851510")]
        public void Method_100a_8d0c()
        {
            ii(0x100a_8d0c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_8d11, 5); calld(Definitions.sys_check_available_stack_size, 0xb_d03c); /* call 0x10165d52 */
            ii(0x100a_8d16, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_8d17, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_8d18, 1); pushd(edx);                             /* push edx */
            ii(0x100a_8d19, 1); pushd(esi);                             /* push esi */
            ii(0x100a_8d1a, 1); pushd(edi);                             /* push edi */
            ii(0x100a_8d1b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_8d1c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_8d1e, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_8d24, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100a_8d2b, 2); jmpd(0x100a_8d33, 0x6); goto l_0x100a_8d33; /* jmp 0x100a8d33 */
        l_0x100a_8d2d:
            ii(0x100a_8d2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_8d30, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100a_8d33:
            ii(0x100a_8d33, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8d37, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100a_8d3a, 2); if(jged(0x100a_8d56, 0x1a)) goto l_0x100a_8d56; /* jge 0x100a8d56 */
            ii(0x100a_8d3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_8d3e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100a_8d42, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_8d48, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_8d4d, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_8d4f, 5); calld(0x100b_de99, 0x1_5145);           /* call 0x100bde99 */
            ii(0x100a_8d54, 2); jmpd(0x100a_8d2d, -0x29); goto l_0x100a_8d2d; /* jmp 0x100a8d2d */
        l_0x100a_8d56:
            ii(0x100a_8d56, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_8d58, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_8d59, 1); popd(edi);                              /* pop edi */
            ii(0x100a_8d5a, 1); popd(esi);                              /* pop esi */
            ii(0x100a_8d5b, 1); popd(edx);                              /* pop edx */
            ii(0x100a_8d5c, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_8d5d, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_8d5e, 1); retd(); return;                         /* ret */
        }
    }
}
