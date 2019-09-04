using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6205-3c29114c")]
        public void Method_1010_6205()
        {
            ii(0x1010_6205, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_620a, 5);  call(Definitions.sys_check_available_stack_size, 0x5_fb43);/* call 0x10165d52 */
            ii(0x1010_620f, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6210, 1);  push(esi);                            /* push esi */
            ii(0x1010_6211, 1);  push(edi);                            /* push edi */
            ii(0x1010_6212, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6213, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6215, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_621b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_621e, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1010_6221, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1010_6224, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_6228, 5);  call(0x1010_60b4, -0x179);            /* call 0x101060b4 */
            ii(0x1010_622d, 1);  push(eax);                            /* push eax */
            ii(0x1010_622e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_6231, 1);  push(eax);                            /* push eax */
            ii(0x1010_6232, 5);  call(0x1012_36fa, 0x1_d4c3);          /* call 0x101236fa */
            ii(0x1010_6237, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1010_623a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_623c, 2);  if(jz(0x1010_6270, 0x32)) goto l_0x1010_6270;/* jz 0x10106270 */
            ii(0x1010_623e, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_6242, 3);  lea(eax, memd[ds, eax + eax * 8]);    /* lea eax, [eax+eax*8] */
            ii(0x1010_6245, 6);  push(memd[ds, eax + 0x101b_8b80]);    /* push dword [eax+0x101b8b80] */
            ii(0x1010_624b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_624e, 1);  push(eax);                            /* push eax */
            ii(0x1010_624f, 5);  call(0x1012_3850, 0x1_d5fc);          /* call 0x10123850 */
            ii(0x1010_6254, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1010_6257, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_6259, 2);  if(jz(0x1010_6270, 0x15)) goto l_0x1010_6270;/* jz 0x10106270 */
            ii(0x1010_625b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_625e, 1);  push(eax);                            /* push eax */
            ii(0x1010_625f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_6262, 1);  push(eax);                            /* push eax */
            ii(0x1010_6263, 5);  call(0x1012_3f33, 0x1_dccb);          /* call 0x10123f33 */
            ii(0x1010_6268, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1010_626b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_626e, 2);  jmp(0x1010_6277, 7); goto l_0x1010_6277;/* jmp 0x10106277 */
        l_0x1010_6270:
            ii(0x1010_6270, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_6277:
            ii(0x1010_6277, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_627a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_627c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_627d, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_627e, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_627f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6280, 1);  ret();                                /* ret */
        }
    }
}
