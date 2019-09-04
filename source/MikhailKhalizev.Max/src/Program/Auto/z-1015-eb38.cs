using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_eb38-baa8588")]
        public void Method_1015_eb38()
        {
            ii(0x1015_eb38, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1015_eb3d, 5);  call(Definitions.sys_check_available_stack_size, 0x7210);/* call 0x10165d52 */
            ii(0x1015_eb42, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_eb43, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_eb44, 1);  push(edx);                            /* push edx */
            ii(0x1015_eb45, 1);  push(esi);                            /* push esi */
            ii(0x1015_eb46, 1);  push(edi);                            /* push edi */
            ii(0x1015_eb47, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_eb48, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_eb4a, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1015_eb50, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_eb53, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_eb56, 5);  call(0x1014_1698, -0x1_d4c3);         /* call 0x10141698 */
            ii(0x1015_eb5b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_eb5e, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_eb62, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_eb65, 5);  call(Definitions.my_ctor_0x101b_38f8, -0xe_847a);/* call 0x100766f0 */
            ii(0x1015_eb6a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_eb6d, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x1015_eb71, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_eb74, 5);  call(0x1007_611c, -0xe_8a5d);         /* call 0x1007611c */
            ii(0x1015_eb79, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x1015_eb7c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_eb7e, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1015_eb80, 5);  call(0x1007_6630, -0xe_8555);         /* call 0x10076630 */
            ii(0x1015_eb85, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_eb88, 5);  call(0x1007_6574, -0xe_8619);         /* call 0x10076574 */
            ii(0x1015_eb8d, 4);  inc(memw[ds, eax + 82]);              /* inc word [eax+0x52] */
            ii(0x1015_eb91, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x1015_eb96, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_eb99, 5);  call(0x1008_b530, -0xd_366e);         /* call 0x1008b530 */
            ii(0x1015_eb9e, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_eba0, 2);  if(jz(0x1015_ebf3, 0x51)) goto l_0x1015_ebf3;/* jz 0x1015ebf3 */
            ii(0x1015_eba2, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_eba5, 5);  call(0x1007_6600, -0xe_85aa);         /* call 0x10076600 */
            ii(0x1015_ebaa, 5);  call(0x1010_094d, -0x5_e262);         /* call 0x1010094d */
            ii(0x1015_ebaf, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_ebb2, 5);  call(0x1007_6574, -0xe_8643);         /* call 0x10076574 */
            ii(0x1015_ebb7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_ebb9, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1015_ebbc, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1015_ebbe, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1015_ebc3, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1015_ebc5, 2);  if(jnz(0x1015_ebf3, 0x2c)) goto l_0x1015_ebf3;/* jnz 0x1015ebf3 */
            ii(0x1015_ebc7, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1015_ebcc, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1015_ebd1, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_ebd4, 5);  call(0x1007_6574, -0xe_8665);         /* call 0x10076574 */
            ii(0x1015_ebd9, 5);  call(0x1007_6204, -0xe_89da);         /* call 0x10076204 */
            ii(0x1015_ebde, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1015_ebe0, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_ebe3, 5);  call(0x1007_6574, -0xe_8674);         /* call 0x10076574 */
            ii(0x1015_ebe8, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1015_ebeb, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1015_ebed, 1);  cwde();                               /* cwde */
            ii(0x1015_ebee, 5);  call(0x1010_11ff, -0x5_d9f4);         /* call 0x101011ff */
        l_0x1015_ebf3:
            ii(0x1015_ebf3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ebf6, 4);  mov(memb[ds, eax + 61], 0x10);        /* mov byte [eax+0x3d], 0x10 */
            ii(0x1015_ebfa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ebfd, 4);  mov(memb[ds, eax + 62], 3);           /* mov byte [eax+0x3e], 0x3 */
            ii(0x1015_ec01, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_ec04, 5);  call(0x1014_b6bd, -0x1_354c);         /* call 0x1014b6bd */
            ii(0x1015_ec09, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_ec0b, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1015_ec0e, 5);  call(0x1007_5f2c, -0xe_8ce7);         /* call 0x10075f2c */
            ii(0x1015_ec13, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_ec15, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_ec16, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_ec17, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_ec18, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_ec19, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_ec1a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_ec1b, 1);  ret();                                /* ret */
        }
    }
}
