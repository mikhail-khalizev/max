using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_91fc-443163ef")]
        public void Method_1008_91fc()
        {
            ii(0x1008_91fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_9201, 5); call(Definitions.sys_check_available_stack_size, 0xd_cb4c); /* call 0x10165d52 */
            ii(0x1008_9206, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9207, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9208, 1); push(esi);                              /* push esi */
            ii(0x1008_9209, 1); push(edi);                              /* push edi */
            ii(0x1008_920a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_920b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_920d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9213, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9216, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_9219, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x1008_9220, 2); if(jz(0x1008_9236, 0x14)) goto l_0x1008_9236; /* jz 0x10089236 */
            ii(0x1008_9222, 5); mov(edx, 0x101b_3a04);                  /* mov edx, 0x101b3a04 */
            ii(0x1008_9227, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_922a, 5); call(Definitions.sys_call_dtor_arr, 0xd_cd89); /* call 0x10165fb8 */
            ii(0x1008_922f, 5); call(Definitions.sys_delete_arr, 0xd_cda4); /* call 0x10165fd8 */
            ii(0x1008_9234, 2); jmp(0x1008_926a, 0x34); goto l_0x1008_926a; /* jmp 0x1008926a */
        l_0x1008_9236:
            ii(0x1008_9236, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9238, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_923b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_923e, 5); call(0x1007_5f2c, -0x1_3317);           /* call 0x10075f2c */
            ii(0x1008_9243, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_9246, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9249, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_924e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9251, 5); call(0x100a_284c, 0x1_95f6);            /* call 0x100a284c */
            ii(0x1008_9256, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_9259, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x1008_9260, 2); if(jz(0x1008_926a, 0x8)) goto l_0x1008_926a; /* jz 0x1008926a */
            ii(0x1008_9262, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9265, 5); call(Definitions.sys_delete, 0xd_ccfa); /* call 0x10165f64 */
        l_0x1008_926a:
            ii(0x1008_926a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_926d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_9270, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_9273, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9275, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9276, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9277, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9278, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9279, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_927a, 1); ret();                                  /* ret */
        }
    }
}
