using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7960-e661105f")]
        public void Method_100b_7960()
        {
            ii(0x100b_7960, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_7965, 5); call(Definitions.sys_check_available_stack_size, 0xa_e3e8); /* call 0x10165d52 */
            ii(0x100b_796a, 1); push(ebx);                              /* push ebx */
            ii(0x100b_796b, 1); push(ecx);                              /* push ecx */
            ii(0x100b_796c, 1); push(esi);                              /* push esi */
            ii(0x100b_796d, 1); push(edi);                              /* push edi */
            ii(0x100b_796e, 1); push(ebp);                              /* push ebp */
            ii(0x100b_796f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7971, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7977, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_797a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_797d, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_7984, 2); if(jz(0x100b_799a, 0x14)) goto l_0x100b_799a; /* jz 0x100b799a */
            ii(0x100b_7986, 5); mov(edx, 0x101b_5120);                  /* mov edx, 0x101b5120 */
            ii(0x100b_798b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_798e, 5); call(Definitions.sys_call_dtor_arr, 0xa_e625); /* call 0x10165fb8 */
            ii(0x100b_7993, 5); call(Definitions.sys_delete_arr, 0xa_e640); /* call 0x10165fd8 */
            ii(0x100b_7998, 2); jmp(0x100b_79ce, 0x34); goto l_0x100b_79ce; /* jmp 0x100b79ce */
        l_0x100b_799a:
            ii(0x100b_799a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_799c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_799f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_79a2, 5); call(Definitions.my_dtor_0x101b_56fc, -0x2_ed6b); /* call 0x10088c3c */
            ii(0x100b_79a7, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_79aa, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_79ad, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_79b2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_79b5, 5); call(0x100a_284c, -0x1_516e);           /* call 0x100a284c */
            ii(0x100b_79ba, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_79bd, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_79c4, 2); if(jz(0x100b_79ce, 0x8)) goto l_0x100b_79ce; /* jz 0x100b79ce */
            ii(0x100b_79c6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_79c9, 5); call(Definitions.sys_delete, 0xa_e596); /* call 0x10165f64 */
        l_0x100b_79ce:
            ii(0x100b_79ce, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_79d1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_79d4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_79d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_79d9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_79da, 1); pop(edi);                               /* pop edi */
            ii(0x100b_79db, 1); pop(esi);                               /* pop esi */
            ii(0x100b_79dc, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_79dd, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_79de, 1); ret();                                  /* ret */
        }
    }
}
