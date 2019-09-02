using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_78e0-9d766134")]
        public void Method_100b_78e0()
        {
            ii(0x100b_78e0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_78e5, 5); call(Definitions.sys_check_available_stack_size, 0xa_e468); /* call 0x10165d52 */
            ii(0x100b_78ea, 1); push(ebx);                              /* push ebx */
            ii(0x100b_78eb, 1); push(ecx);                              /* push ecx */
            ii(0x100b_78ec, 1); push(esi);                              /* push esi */
            ii(0x100b_78ed, 1); push(edi);                              /* push edi */
            ii(0x100b_78ee, 1); push(ebp);                              /* push ebp */
            ii(0x100b_78ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_78f1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_78f7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_78fa, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_78fd, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_7904, 2); if(jz(0x100b_791a, 0x14)) goto l_0x100b_791a; /* jz 0x100b791a */
            ii(0x100b_7906, 5); mov(edx, 0x101b_510c);                  /* mov edx, 0x101b510c */
            ii(0x100b_790b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_790e, 5); call(Definitions.sys_call_dtor_arr, 0xa_e6a5); /* call 0x10165fb8 */
            ii(0x100b_7913, 5); call(Definitions.sys_delete_arr, 0xa_e6c0); /* call 0x10165fd8 */
            ii(0x100b_7918, 2); jmp(0x100b_794e, 0x34); goto l_0x100b_794e; /* jmp 0x100b794e */
        l_0x100b_791a:
            ii(0x100b_791a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_791c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_791f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_7922, 5); call(0x1007_5f2c, -0x4_19fb);           /* call 0x10075f2c */
            ii(0x100b_7927, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_792a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_792d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_7932, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7935, 5); call(0x100a_284c, -0x1_50ee);           /* call 0x100a284c */
            ii(0x100b_793a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_793d, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_7944, 2); if(jz(0x100b_794e, 8)) goto l_0x100b_794e; /* jz 0x100b794e */
            ii(0x100b_7946, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7949, 5); call(Definitions.sys_delete, 0xa_e616); /* call 0x10165f64 */
        l_0x100b_794e:
            ii(0x100b_794e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7951, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_7954, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_7957, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7959, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_795a, 1); pop(edi);                               /* pop edi */
            ii(0x100b_795b, 1); pop(esi);                               /* pop esi */
            ii(0x100b_795c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_795d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_795e, 1); ret();                                  /* ret */
        }
    }
}
