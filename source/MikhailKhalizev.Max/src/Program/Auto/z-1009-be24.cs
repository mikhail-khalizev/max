using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_be24-8a950bc5")]
        public void Method_1009_be24()
        {
            ii(0x1009_be24, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_be29, 5); call(Definitions.sys_check_available_stack_size, 0xc_9f24); /* call 0x10165d52 */
            ii(0x1009_be2e, 1); push(ebx);                              /* push ebx */
            ii(0x1009_be2f, 1); push(ecx);                              /* push ecx */
            ii(0x1009_be30, 1); push(esi);                              /* push esi */
            ii(0x1009_be31, 1); push(edi);                              /* push edi */
            ii(0x1009_be32, 1); push(ebp);                              /* push ebp */
            ii(0x1009_be33, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_be35, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_be3b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_be3e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_be41, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_be48, 2); if(jz(0x1009_be5e, 0x14)) goto l_0x1009_be5e; /* jz 0x1009be5e */
            ii(0x1009_be4a, 5); mov(edx, 0x101b_410c);                  /* mov edx, 0x101b410c */
            ii(0x1009_be4f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_be52, 5); call(Definitions.sys_call_dtor_arr, 0xc_a161); /* call 0x10165fb8 */
            ii(0x1009_be57, 5); call(Definitions.sys_delete_arr, 0xc_a17c); /* call 0x10165fd8 */
            ii(0x1009_be5c, 2); jmp(0x1009_be92, 0x34); goto l_0x1009_be92; /* jmp 0x1009be92 */
        l_0x1009_be5e:
            ii(0x1009_be5e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_be60, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_be63, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_be66, 5); call(0x1009_bbf8, -0x273);              /* call 0x1009bbf8 */
            ii(0x1009_be6b, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_be6e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_be71, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_be76, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_be79, 5); call(0x100a_284c, 0x69ce);              /* call 0x100a284c */
            ii(0x1009_be7e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_be81, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_be88, 2); if(jz(0x1009_be92, 0x8)) goto l_0x1009_be92; /* jz 0x1009be92 */
            ii(0x1009_be8a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_be8d, 5); call(Definitions.sys_delete, 0xc_a0d2); /* call 0x10165f64 */
        l_0x1009_be92:
            ii(0x1009_be92, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_be95, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_be98, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_be9b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_be9d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_be9e, 1); pop(edi);                               /* pop edi */
            ii(0x1009_be9f, 1); pop(esi);                               /* pop esi */
            ii(0x1009_bea0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_bea1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_bea2, 1); ret();                                  /* ret */
        }
    }
}
