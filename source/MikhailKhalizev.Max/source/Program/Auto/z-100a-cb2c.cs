using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_cb2c-30f8fef4")]
        public void Method_100a_cb2c()
        {
            ii(0x100a_cb2c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_cb31, 5);  call(Definitions.sys_check_available_stack_size, 0xb_921c);/* call 0x10165d52 */
            ii(0x100a_cb36, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_cb37, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_cb38, 1);  push(edx);                            /* push edx */
            ii(0x100a_cb39, 1);  push(esi);                            /* push esi */
            ii(0x100a_cb3a, 1);  push(edi);                            /* push edi */
            ii(0x100a_cb3b, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_cb3c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_cb3e, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_cb44, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_cb47, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_cb4a, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_cb4d, 5);  call(0x1007_65d0, -0x3_6582);         /* call 0x100765d0 */
            ii(0x100a_cb52, 5);  call(0x100a_b50c, -0x164b);           /* call 0x100ab50c */
            ii(0x100a_cb57, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_cb5a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_cb5d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_cb60, 5);  call(0x1007_6574, -0x3_65f1);         /* call 0x10076574 */
            ii(0x100a_cb65, 5);  call(0x1015_27ed, 0xa_5c83);          /* call 0x101527ed */
            ii(0x100a_cb6a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_cb6d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_cb70, 5);  call(0x1007_6574, -0x3_6601);         /* call 0x10076574 */
            ii(0x100a_cb75, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100a_cb79, 2);  if(jnz(0x100a_cb88, 0xd)) goto l_0x100a_cb88;/* jnz 0x100acb88 */
            ii(0x100a_cb7b, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_cb80, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_cb83, 5);  call(0x100a_2a04, -0xa184);           /* call 0x100a2a04 */
        l_0x100a_cb88:
            ii(0x100a_cb88, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_cb8b, 5);  cmp(memw[ds, eax + 38], -1 /* 0xff */);/* cmp word [eax+0x26], 0xffff */
            ii(0x100a_cb90, 2);  if(jnz(0x100a_cba3, 0x11)) goto l_0x100a_cba3;/* jnz 0x100acba3 */
            ii(0x100a_cb92, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_cb95, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_cb98, 5);  call(0x1007_6574, -0x3_6629);         /* call 0x10076574 */
            ii(0x100a_cb9d, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100a_cba1, 2);  if(jnz(0x100a_cba5, 2)) goto l_0x100a_cba5;/* jnz 0x100acba5 */
        l_0x100a_cba3:
            ii(0x100a_cba3, 2);  jmp(0x100a_cbb2, 0xd); goto l_0x100a_cbb2;/* jmp 0x100acbb2 */
        l_0x100a_cba5:
            ii(0x100a_cba5, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_cbaa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_cbad, 5);  call(0x100a_cbbb, 9);                 /* call 0x100acbbb */
        l_0x100a_cbb2:
            ii(0x100a_cbb2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_cbb4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_cbb5, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_cbb6, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_cbb7, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_cbb8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_cbb9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_cbba, 1);  ret();                                /* ret */
        }
    }
}
