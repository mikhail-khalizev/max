using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_74e8-ef00ea5c")]
        public void Method_100b_74e8()
        {
            ii(0x100b_74e8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_74ed, 5); call(Definitions.sys_check_available_stack_size, 0xa_e860); /* call 0x10165d52 */
            ii(0x100b_74f2, 1); push(ebx);                              /* push ebx */
            ii(0x100b_74f3, 1); push(ecx);                              /* push ecx */
            ii(0x100b_74f4, 1); push(esi);                              /* push esi */
            ii(0x100b_74f5, 1); push(edi);                              /* push edi */
            ii(0x100b_74f6, 1); push(ebp);                              /* push ebp */
            ii(0x100b_74f7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_74f9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_74ff, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7502, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7505, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_750c, 2); if(jz(0x100b_7522, 0x14)) goto l_0x100b_7522; /* jz 0x100b7522 */
            ii(0x100b_750e, 5); mov(edx, 0x101b_5094);                  /* mov edx, 0x101b5094 */
            ii(0x100b_7513, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7516, 5); call(Definitions.sys_call_dtor_arr, 0xa_ea9d); /* call 0x10165fb8 */
            ii(0x100b_751b, 5); call(Definitions.sys_delete_arr, 0xa_eab8); /* call 0x10165fd8 */
            ii(0x100b_7520, 2); jmp(0x100b_7556, 0x34); goto l_0x100b_7556; /* jmp 0x100b7556 */
        l_0x100b_7522:
            ii(0x100b_7522, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_7524, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7527, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100b_752a, 5); call(0x100a_9f38, -0xd5f7);             /* call 0x100a9f38 */
            ii(0x100b_752f, 3); sub(eax, 0x20);                         /* sub eax, 0x20 */
            ii(0x100b_7532, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7535, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_753a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_753d, 5); call(0x100b_7468, -0xda);               /* call 0x100b7468 */
            ii(0x100b_7542, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7545, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_754c, 2); if(jz(0x100b_7556, 0x8)) goto l_0x100b_7556; /* jz 0x100b7556 */
            ii(0x100b_754e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7551, 5); call(Definitions.sys_delete, 0xa_ea0e); /* call 0x10165f64 */
        l_0x100b_7556:
            ii(0x100b_7556, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7559, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_755c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_755f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7561, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7562, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7563, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7564, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7565, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7566, 1); ret();                                  /* ret */
        }
    }
}
