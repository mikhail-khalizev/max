using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cc08-6e13db63")]
        public void Method_1009_cc08()
        {
            ii(0x1009_cc08, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1009_cc0d, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9140);/* call 0x10165d52 */
            ii(0x1009_cc12, 1);  push(esi);                            /* push esi */
            ii(0x1009_cc13, 1);  push(edi);                            /* push edi */
            ii(0x1009_cc14, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_cc15, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_cc17, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1009_cc1d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_cc20, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_cc23, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x1009_cc26, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1009_cc29, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1009_cc2d, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1009_cc30, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1009_cc34, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cc37, 5);  call(0x100a_26d1, 0x5a95);            /* call 0x100a26d1 */
            ii(0x1009_cc3c, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_cc3f, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1009_cc42, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_cc45, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cc48, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_cc4b, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_6160);/* call 0x10076af0 */
            ii(0x1009_cc50, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x1009_cc53, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_cc56, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cc59, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_cc5c, 5);  call(Definitions.my_ctor_0x101b_56fc, -0x1_3fe5);/* call 0x10088c7c */
            ii(0x1009_cc61, 3);  sub(eax, 0x17);                       /* sub eax, 0x17 */
            ii(0x1009_cc64, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_cc67, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1009_cc6a, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_cc6d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cc70, 7);  mov(memd[ds, eax + 2], 0x101b_4b2c);  /* mov dword [eax+0x2], 0x101b4b2c */
            ii(0x1009_cc77, 3);  mov(edx, memd[ss, ebp + 16]);         /* mov edx, [ebp+0x10] */
            ii(0x1009_cc7a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cc7d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_cc80, 5);  call(0x1008_8b44, -0x1_4141);         /* call 0x10088b44 */
            ii(0x1009_cc85, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cc88, 6);  mov(memw[ds, eax + 33], 0);           /* mov word [eax+0x21], 0x0 */
            ii(0x1009_cc8e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_cc91, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_cc94, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_cc97, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_cc99, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_cc9a, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_cc9b, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_cc9c, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
