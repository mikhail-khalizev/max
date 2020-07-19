using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d461-febe77d9")]
        public void Method_100c_d461()
        {
            ii(0x100c_d461, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_d466, 5);  call(Definitions.sys_check_available_stack_size, 0x9_88e7);/* call 0x10165d52 */
            ii(0x100c_d46b, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_d46c, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_d46d, 1);  push(edx);                            /* push edx */
            ii(0x100c_d46e, 1);  push(esi);                            /* push esi */
            ii(0x100c_d46f, 1);  push(edi);                            /* push edi */
            ii(0x100c_d470, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_d471, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_d473, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_d479, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_d47c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d47f, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_d482, 5);  call(0x1007_65d0, -0x5_6eb7);         /* call 0x100765d0 */
            ii(0x100c_d487, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_d489, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d48c, 3);  mov(ebx, memd[ds, eax + 7]);          /* mov ebx, [eax+0x7] */
            ii(0x100c_d48f, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_d492, 6);  imul(ebx, ebx, 0xc5);                 /* imul ebx, ebx, 0xc5 */
            ii(0x100c_d498, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x100c_d49d, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100c_d49f, 5);  call(0x100c_343a, -0xa06a);           /* call 0x100c343a */
            ii(0x100c_d4a4, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_d4a6, 2);  if(jz(0x100c_d4cd, 0x25)) goto l_0x100c_d4cd;/* jz 0x100cd4cd */
            ii(0x100c_d4a8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d4ab, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_d4ae, 5);  call(0x1007_6574, -0x5_6f3f);         /* call 0x10076574 */
            ii(0x100c_d4b3, 5);  call(0x1015_09a6, 0x8_34ee);          /* call 0x101509a6 */
            ii(0x100c_d4b8, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100c_d4bb, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100c_d4bd, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100c_d4c0, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_d4c3, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x100c_d4c5, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x100c_d4c8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_d4cb, 2);  jmp(0x100c_d4d4, 7); goto l_0x100c_d4d4;/* jmp 0x100cd4d4 */
        l_0x100c_d4cd:
            ii(0x100c_d4cd, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
        l_0x100c_d4d4:
            ii(0x100c_d4d4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d4d7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_d4d9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_d4da, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_d4db, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_d4dc, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_d4dd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_d4de, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_d4df, 1);  ret();                                /* ret */
        }
    }
}
