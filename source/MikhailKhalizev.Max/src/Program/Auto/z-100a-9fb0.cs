using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9fb0-779f7ad0")]
        public void Method_100a_9fb0()
        {
            ii(0x100a_9fb0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_9fb5, 5); call(Definitions.sys_check_available_stack_size, 0xb_bd98); /* call 0x10165d52 */
            ii(0x100a_9fba, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9fbb, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9fbc, 1); push(esi);                              /* push esi */
            ii(0x100a_9fbd, 1); push(edi);                              /* push edi */
            ii(0x100a_9fbe, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9fbf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9fc1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_9fc7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_9fca, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_9fcd, 7); test(memd[ss, ebp - 4], 4);             /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_9fd4, 2); if(jz(0x100a_9fea, 0x14)) goto l_0x100a_9fea; /* jz 0x100a9fea */
            ii(0x100a_9fd6, 5); mov(edx, 0x101b_4c40);                  /* mov edx, 0x101b4c40 */
            ii(0x100a_9fdb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_9fde, 5); call(Definitions.sys_call_dtor_arr, 0xb_bfd5); /* call 0x10165fb8 */
            ii(0x100a_9fe3, 5); call(Definitions.sys_delete_arr, 0xb_bff0); /* call 0x10165fd8 */
            ii(0x100a_9fe8, 2); jmp(0x100a_a01e, 0x34); goto l_0x100a_a01e; /* jmp 0x100aa01e */
        l_0x100a_9fea:
            ii(0x100a_9fea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_9fec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_9fef, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_9ff2, 5); call(0x1008_8b04, -0x2_14f3);           /* call 0x10088b04 */
            ii(0x100a_9ff7, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100a_9ffa, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_9ffd, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100a_a002, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a005, 5); call(0x100a_284c, -0x77be);             /* call 0x100a284c */
            ii(0x100a_a00a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a00d, 7); test(memd[ss, ebp - 4], 2);             /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a014, 2); if(jz(0x100a_a01e, 8)) goto l_0x100a_a01e; /* jz 0x100aa01e */
            ii(0x100a_a016, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a019, 5); call(Definitions.sys_delete, 0xb_bf46); /* call 0x10165f64 */
        l_0x100a_a01e:
            ii(0x100a_a01e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a021, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_a024, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_a027, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a029, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a02a, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a02b, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a02c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a02d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a02e, 1); ret();                                  /* ret */
        }
    }
}
