using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_bb8b-2082349f")]
        public void Method_100c_bb8b()
        {
            ii(0x100c_bb8b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_bb90, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a1bd);/* call 0x10165d52 */
            ii(0x100c_bb95, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_bb96, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_bb97, 1);  push(edx);                            /* push edx */
            ii(0x100c_bb98, 1);  push(esi);                            /* push esi */
            ii(0x100c_bb99, 1);  push(edi);                            /* push edi */
            ii(0x100c_bb9a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_bb9b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_bb9d, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_bba3, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_bba6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bba9, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bbac, 5);  call(0x1007_6574, -0x5_563d);         /* call 0x10076574 */
            ii(0x100c_bbb1, 5);  cmp(memw[ds, eax + 8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x100c_bbb6, 2);  if(jz(0x100c_bbca, 0x12)) goto l_0x100c_bbca;/* jz 0x100cbbca */
            ii(0x100c_bbb8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bbbb, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bbbe, 5);  call(0x1007_6574, -0x5_564f);         /* call 0x10076574 */
            ii(0x100c_bbc3, 5);  cmp(memw[ds, eax + 8], 0x43);         /* cmp word [eax+0x8], 0x43 */
            ii(0x100c_bbc8, 2);  if(jnz(0x100c_bbd3, 9)) goto l_0x100c_bbd3;/* jnz 0x100cbbd3 */
        l_0x100c_bbca:
            ii(0x100c_bbca, 7);  mov(memd[ss, ebp - 8], 3);            /* mov dword [ebp-0x8], 0x3 */
            ii(0x100c_bbd1, 2);  jmp(0x100c_bc28, 0x55); goto l_0x100c_bc28;/* jmp 0x100cbc28 */
        l_0x100c_bbd3:
            ii(0x100c_bbd3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bbd6, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bbd9, 5);  call(0x1007_6574, -0x5_566a);         /* call 0x10076574 */
            ii(0x100c_bbde, 4);  test(memb[ds, eax + 19], 1);          /* test byte [eax+0x13], 0x1 */
            ii(0x100c_bbe2, 2);  if(jz(0x100c_bbed, 9)) goto l_0x100c_bbed;/* jz 0x100cbbed */
            ii(0x100c_bbe4, 7);  mov(memd[ss, ebp - 8], 9);            /* mov dword [ebp-0x8], 0x9 */
            ii(0x100c_bbeb, 2);  jmp(0x100c_bc28, 0x3b); goto l_0x100c_bc28;/* jmp 0x100cbc28 */
        l_0x100c_bbed:
            ii(0x100c_bbed, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bbf0, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bbf3, 5);  call(0x1007_6574, -0x5_5684);         /* call 0x10076574 */
            ii(0x100c_bbf8, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100c_bbfc, 2);  if(jz(0x100c_bc07, 9)) goto l_0x100c_bc07;/* jz 0x100cbc07 */
            ii(0x100c_bbfe, 7);  mov(memd[ss, ebp - 8], 0xa);          /* mov dword [ebp-0x8], 0xa */
            ii(0x100c_bc05, 2);  jmp(0x100c_bc28, 0x21); goto l_0x100c_bc28;/* jmp 0x100cbc28 */
        l_0x100c_bc07:
            ii(0x100c_bc07, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bc0a, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bc0d, 5);  call(0x1007_6574, -0x5_569e);         /* call 0x10076574 */
            ii(0x100c_bc12, 4);  test(memb[ds, eax + 18], 0x80);       /* test byte [eax+0x12], 0x80 */
            ii(0x100c_bc16, 2);  if(jz(0x100c_bc21, 9)) goto l_0x100c_bc21;/* jz 0x100cbc21 */
            ii(0x100c_bc18, 7);  mov(memd[ss, ebp - 8], 0xb);          /* mov dword [ebp-0x8], 0xb */
            ii(0x100c_bc1f, 2);  jmp(0x100c_bc28, 7); goto l_0x100c_bc28;/* jmp 0x100cbc28 */
        l_0x100c_bc21:
            ii(0x100c_bc21, 7);  mov(memd[ss, ebp - 8], 0xffff_ffff);  /* mov dword [ebp-0x8], 0xffffffff */
        l_0x100c_bc28:
            ii(0x100c_bc28, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_bc2b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_bc2d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_bc2e, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_bc2f, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_bc30, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_bc31, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_bc32, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_bc33, 1);  ret();                                /* ret */
        }
    }
}
