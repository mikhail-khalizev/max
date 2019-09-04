using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4715-77af56d")]
        public void Method_100b_4715()
        {
            ii(0x100b_4715, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100b_471a, 5);  call(Definitions.sys_check_available_stack_size, 0xb_1633);/* call 0x10165d52 */
            ii(0x100b_471f, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_4720, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_4721, 1);  push(edx);                            /* push edx */
            ii(0x100b_4722, 1);  push(esi);                            /* push esi */
            ii(0x100b_4723, 1);  push(edi);                            /* push edi */
            ii(0x100b_4724, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_4725, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_4727, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_472d, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_4730, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_4732, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4735, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_4738, 5);  call(0x1013_ad11, 0x8_65d4);          /* call 0x1013ad11 */
            ii(0x100b_473d, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_473f, 2);  if(jnz(0x100b_4752, 0x11)) goto l_0x100b_4752;/* jnz 0x100b4752 */
            ii(0x100b_4741, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_4743, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4746, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_4749, 5);  call(0x1013_ad11, 0x8_65c3);          /* call 0x1013ad11 */
            ii(0x100b_474e, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_4750, 2);  if(jz(0x100b_4757, 5)) goto l_0x100b_4757;/* jz 0x100b4757 */
        l_0x100b_4752:
            ii(0x100b_4752, 5);  jmp(0x100b_4819, 0xc2); goto l_0x100b_4819;/* jmp 0x100b4819 */
        l_0x100b_4757:
            ii(0x100b_4757, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_475a, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_475d, 5);  call(0x1007_6574, -0x3_e1ee);         /* call 0x10076574 */
            ii(0x100b_4762, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100b_4766, 2);  if(jnz(0x100b_477d, 0x15)) goto l_0x100b_477d;/* jnz 0x100b477d */
            ii(0x100b_4768, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_476b, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_476e, 5);  call(0x1007_6574, -0x3_e1ff);         /* call 0x10076574 */
            ii(0x100b_4773, 5);  call(0x1015_26ac, 0x9_df34);          /* call 0x101526ac */
            ii(0x100b_4778, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100b_477b, 2);  if(jz(0x100b_477f, 2)) goto l_0x100b_477f;/* jz 0x100b477f */
        l_0x100b_477d:
            ii(0x100b_477d, 2);  jmp(0x100b_4796, 0x17); goto l_0x100b_4796;/* jmp 0x100b4796 */
        l_0x100b_477f:
            ii(0x100b_477f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4782, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_4785, 5);  call(0x1007_6574, -0x3_e216);         /* call 0x10076574 */
            ii(0x100b_478a, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x100b_478d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100b_4792, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_4794, 2);  if(jg(0x100b_4798, 2)) goto l_0x100b_4798;/* jg 0x100b4798 */
        l_0x100b_4796:
            ii(0x100b_4796, 2);  jmp(0x100b_47b9, 0x21); goto l_0x100b_47b9;/* jmp 0x100b47b9 */
        l_0x100b_4798:
            ii(0x100b_4798, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_479b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_479e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_47a1, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100b_47a4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_47a7, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_47aa, 5);  call(0x1007_65d0, -0x3_e1df);         /* call 0x100765d0 */
            ii(0x100b_47af, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_47b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_47b4, 3);  call_abs(memd[ds, ebx + 68]);         /* call dword [ebx+0x44] */
            ii(0x100b_47b7, 2);  jmp(0x100b_4819, 0x60); goto l_0x100b_4819;/* jmp 0x100b4819 */
        l_0x100b_47b9:
            ii(0x100b_47b9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_47bc, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_47bf, 5);  call(0x1007_6574, -0x3_e250);         /* call 0x10076574 */
            ii(0x100b_47c4, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100b_47c8, 2);  if(jnz(0x100b_47df, 0x15)) goto l_0x100b_47df;/* jnz 0x100b47df */
            ii(0x100b_47ca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_47cd, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_47d0, 5);  call(0x1007_6574, -0x3_e261);         /* call 0x10076574 */
            ii(0x100b_47d5, 5);  call(0x1015_26ac, 0x9_ded2);          /* call 0x101526ac */
            ii(0x100b_47da, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100b_47dd, 2);  if(jz(0x100b_47e1, 2)) goto l_0x100b_47e1;/* jz 0x100b47e1 */
        l_0x100b_47df:
            ii(0x100b_47df, 2);  jmp(0x100b_47f8, 0x17); goto l_0x100b_47f8;/* jmp 0x100b47f8 */
        l_0x100b_47e1:
            ii(0x100b_47e1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_47e4, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_47e7, 5);  call(0x1007_6574, -0x3_e278);         /* call 0x10076574 */
            ii(0x100b_47ec, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x100b_47ef, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100b_47f4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_47f6, 2);  if(jg(0x100b_47fa, 2)) goto l_0x100b_47fa;/* jg 0x100b47fa */
        l_0x100b_47f8:
            ii(0x100b_47f8, 2);  jmp(0x100b_4819, 0x1f); goto l_0x100b_4819;/* jmp 0x100b4819 */
        l_0x100b_47fa:
            ii(0x100b_47fa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_47fd, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_4800, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_4803, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x100b_4806, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4809, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_480c, 5);  call(0x1007_65d0, -0x3_e241);         /* call 0x100765d0 */
            ii(0x100b_4811, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100b_4813, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_4816, 3);  call_abs(memd[ds, ebx + 68]);         /* call dword [ebx+0x44] */
        l_0x100b_4819:
            ii(0x100b_4819, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_481b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_481c, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_481d, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_481e, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_481f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_4820, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_4821, 1);  ret();                                /* ret */
        }
    }
}
