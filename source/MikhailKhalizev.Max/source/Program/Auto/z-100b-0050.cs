using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0050-5edcdc63")]
        public void Method_100b_0050()
        {
            ii(0x100b_0050, 5);  push(0x34);                           /* push 0x34 */
            ii(0x100b_0055, 5);  call(Definitions.sys_check_available_stack_size, 0xb_5cf8);/* call 0x10165d52 */
            ii(0x100b_005a, 1);  push(esi);                            /* push esi */
            ii(0x100b_005b, 1);  push(edi);                            /* push edi */
            ii(0x100b_005c, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_005d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_005f, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100b_0065, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_0068, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100b_006b, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100b_006e, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100b_0071, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_0074, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100b_0077, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_007a, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_007d, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100b_0080, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x100b_0083, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100b_0086, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100b_0089, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_008c, 5);  call(0x1008_ad90, -0x2_5301);         /* call 0x1008ad90 */
            ii(0x100b_0091, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100b_0094, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_0097, 5);  call(0x100a_26d1, -0xd9cb);           /* call 0x100a26d1 */
            ii(0x100b_009c, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_009f, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_00a2, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100b_00a5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_00a8, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_00ab, 5);  call(0x1008_a634, -0x2_5a7c);         /* call 0x1008a634 */
            ii(0x100b_00b0, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x100b_00b3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_00b6, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_00b9, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100b_00bc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_00bf, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_00c2, 5);  call(Definitions.my_ctor_0x101b_38f8, -0x3_99d7);/* call 0x100766f0 */
            ii(0x100b_00c7, 3);  sub(eax, 0x17);                       /* sub eax, 0x17 */
            ii(0x100b_00ca, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_00cd, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100b_00d0, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_00d3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_00d6, 3);  add(eax, 0x21);                       /* add eax, 0x21 */
            ii(0x100b_00d9, 5);  call(Definitions.my_ctor_0x101b_4184, -0x3_95ee);/* call 0x10076af0 */
            ii(0x100b_00de, 3);  sub(eax, 0x21);                       /* sub eax, 0x21 */
            ii(0x100b_00e1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_00e4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_00e7, 7);  mov(memd[ds, eax + 2], 0x101b_5424);  /* mov dword [eax+0x2], 0x101b5424 */
            ii(0x100b_00ee, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_00f1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_00f4, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_00f7, 5);  call(0x1007_6630, -0x3_9acc);         /* call 0x10076630 */
            ii(0x100b_00fc, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_00ff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_0102, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_0105, 5);  call(0x100b_7cfc, 0x7bf2);            /* call 0x100b7cfc */
            ii(0x100b_010a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_010d, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100b_0110, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_0113, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_0115, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_0116, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_0117, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_0118, 1);  ret();                                /* ret */
        }
    }
}
