using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_6ecc-7a786d2e")]
        public void Method_1008_6ecc()
        {
            ii(0x1008_6ecc, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1008_6ed1, 5);  call(Definitions.sys_check_available_stack_size, 0xd_ee7c);/* call 0x10165d52 */
            ii(0x1008_6ed6, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_6ed7, 1);  push(esi);                            /* push esi */
            ii(0x1008_6ed8, 1);  push(edi);                            /* push edi */
            ii(0x1008_6ed9, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_6eda, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_6edc, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1008_6ee2, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_6ee5, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1008_6ee8, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1008_6eeb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_6eee, 5);  call(0x1007_6338, -0x1_0bbb);         /* call 0x10076338 */
            ii(0x1008_6ef3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_6ef5, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6ef8, 5);  call(0x1007_64b8, -0x1_0a45);         /* call 0x100764b8 */
            ii(0x1008_6efd, 2);  jmp(0x1008_6f07, 8); goto l_0x1008_6f07;/* jmp 0x10086f07 */
        l_0x1008_6eff:
            ii(0x1008_6eff, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f02, 5);  call(0x1007_6bf8, -0x1_030f);         /* call 0x10076bf8 */
        l_0x1008_6f07:
            ii(0x1008_6f07, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_6f09, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f0c, 5);  call(0x1013_ad71, 0xb_3e60);          /* call 0x1013ad71 */
            ii(0x1008_6f11, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_6f13, 6);  if(jz(0x1008_7071, 0x158)) goto l_0x1008_7071;/* jz 0x10087071 */
            ii(0x1008_6f19, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f1c, 5);  call(0x1007_63a0, -0x1_0b81);         /* call 0x100763a0 */
            ii(0x1008_6f21, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_6f23, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1008_6f26, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_6f29, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_6f2c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_6f2f, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_6f31, 2);  if(jnz(0x1008_6f46, 0x13)) goto l_0x1008_6f46;/* jnz 0x10086f46 */
            ii(0x1008_6f33, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f36, 5);  call(0x1007_63a0, -0x1_0b9b);         /* call 0x100763a0 */
            ii(0x1008_6f3b, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1008_6f3e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_6f41, 3);  test(memd[ds, eax + 33], edx);        /* test [eax+0x21], edx */
            ii(0x1008_6f44, 2);  if(jnz(0x1008_6f48, 2)) goto l_0x1008_6f48;/* jnz 0x10086f48 */
        l_0x1008_6f46:
            ii(0x1008_6f46, 2);  jmp(0x1008_6f6c, 0x24); goto l_0x1008_6f6c;/* jmp 0x10086f6c */
        l_0x1008_6f48:
            ii(0x1008_6f48, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f4b, 5);  call(0x1007_63a0, -0x1_0bb0);         /* call 0x100763a0 */
            ii(0x1008_6f50, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_6f52, 3);  mov(dl, memb[ds, eax + 84]);          /* mov dl, [eax+0x54] */
            ii(0x1008_6f55, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f58, 5);  call(0x1007_63a0, -0x1_0bbd);         /* call 0x100763a0 */
            ii(0x1008_6f5d, 5);  call(0x1007_623c, -0x1_0d26);         /* call 0x1007623c */
            ii(0x1008_6f62, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1008_6f65, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_6f68, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1008_6f6a, 2);  if(jg(0x1008_6f6e, 2)) goto l_0x1008_6f6e;/* jg 0x10086f6e */
        l_0x1008_6f6c:
            ii(0x1008_6f6c, 2);  jmp(0x1008_6f82, 0x14); goto l_0x1008_6f82;/* jmp 0x10086f82 */
        l_0x1008_6f6e:
            ii(0x1008_6f6e, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f71, 5);  call(0x1007_63a0, -0x1_0bd6);         /* call 0x100763a0 */
            ii(0x1008_6f76, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1008_6f79, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_6f7e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_6f80, 2);  if(jg(0x1008_6f87, 5)) goto l_0x1008_6f87;/* jg 0x10086f87 */
        l_0x1008_6f82:
            ii(0x1008_6f82, 5);  jmp(0x1008_706c, 0xe5); goto l_0x1008_706c;/* jmp 0x1008706c */
        l_0x1008_6f87:
            ii(0x1008_6f87, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f8a, 5);  call(0x1007_63a0, -0x1_0bef);         /* call 0x100763a0 */
            ii(0x1008_6f8f, 4);  cmp(memb[ds, eax + 61], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_6f93, 2);  if(jz(0x1008_6fa3, 0xe)) goto l_0x1008_6fa3;/* jz 0x10086fa3 */
            ii(0x1008_6f95, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6f98, 5);  call(0x1007_63a0, -0x1_0bfd);         /* call 0x100763a0 */
            ii(0x1008_6f9d, 4);  cmp(memb[ds, eax + 61], 0xc);         /* cmp byte [eax+0x3d], 0xc */
            ii(0x1008_6fa1, 2);  if(jnz(0x1008_6fa5, 2)) goto l_0x1008_6fa5;/* jnz 0x10086fa5 */
        l_0x1008_6fa3:
            ii(0x1008_6fa3, 2);  jmp(0x1008_6fb3, 0xe); goto l_0x1008_6fb3;/* jmp 0x10086fb3 */
        l_0x1008_6fa5:
            ii(0x1008_6fa5, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6fa8, 5);  call(0x1007_63a0, -0x1_0c0d);         /* call 0x100763a0 */
            ii(0x1008_6fad, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1008_6fb1, 2);  if(jnz(0x1008_6fb5, 2)) goto l_0x1008_6fb5;/* jnz 0x10086fb5 */
        l_0x1008_6fb3:
            ii(0x1008_6fb3, 2);  jmp(0x1008_6fc7, 0x12); goto l_0x1008_6fc7;/* jmp 0x10086fc7 */
        l_0x1008_6fb5:
            ii(0x1008_6fb5, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6fb8, 5);  call(0x1007_63a0, -0x1_0c1d);         /* call 0x100763a0 */
            ii(0x1008_6fbd, 4);  cmp(memb[ds, eax + 61], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1008_6fc1, 6);  if(jnz(0x1008_706c, 0xa5)) goto l_0x1008_706c;/* jnz 0x1008706c */
        l_0x1008_6fc7:
            ii(0x1008_6fc7, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6fca, 5);  call(0x1007_63d4, -0x1_0bfb);         /* call 0x100763d4 */
            ii(0x1008_6fcf, 5);  call(0x1007_6ec0, -0x1_0114);         /* call 0x10076ec0 */
            ii(0x1008_6fd4, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_6fd7, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_6fda, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1008_6fde, 6);  if(jg(0x1008_706c, 0x88)) goto l_0x1008_706c;/* jg 0x1008706c */
            ii(0x1008_6fe4, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_6fe7, 5);  call(0x1007_63a0, -0x1_0c4c);         /* call 0x100763a0 */
            ii(0x1008_6fec, 5);  call(0x1015_26ac, 0xc_b6bb);          /* call 0x101526ac */
            ii(0x1008_6ff1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_6ff3, 2);  if(jz(0x1008_7043, 0x4e)) goto l_0x1008_7043;/* jz 0x10087043 */
            ii(0x1008_6ff5, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_6ff8, 3);  mov(edx, memd[ds, eax + 11]);         /* mov edx, [eax+0xb] */
            ii(0x1008_6ffb, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_6ffe, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_7001, 5);  call(0x1007_63a0, -0x1_0c66);         /* call 0x100763a0 */
            ii(0x1008_7006, 5);  call(0x1015_26ac, 0xc_b6a1);          /* call 0x101526ac */
            ii(0x1008_700b, 5);  call(0x100a_2bc4, 0x1_bbb4);          /* call 0x100a2bc4 */
            ii(0x1008_7010, 1);  cwde();                               /* cwde */
            ii(0x1008_7011, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_7013, 2);  if(jle(0x1008_7041, 0x2c)) goto l_0x1008_7041;/* jle 0x10087041 */
            ii(0x1008_7015, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_7018, 5);  call(0x1007_63a0, -0x1_0c7d);         /* call 0x100763a0 */
            ii(0x1008_701d, 5);  call(0x1015_26ac, 0xc_b68a);          /* call 0x101526ac */
            ii(0x1008_7022, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_7025, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_7028, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_702b, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_702e, 5);  call(0x1007_63d4, -0x1_0c5f);         /* call 0x100763d4 */
            ii(0x1008_7033, 3);  mov(ecx, memd[ss, ebp - 24]);         /* mov ecx, [ebp-0x18] */
            ii(0x1008_7036, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_7038, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1008_703a, 3);  call_abs(memd[ds, ebx + 4]);          /* call dword [ebx+0x4] */
            ii(0x1008_703d, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_703f, 2);  if(jnz(0x1008_7043, 2)) goto l_0x1008_7043;/* jnz 0x10087043 */
        l_0x1008_7041:
            ii(0x1008_7041, 2);  jmp(0x1008_706c, 0x29); goto l_0x1008_706c;/* jmp 0x1008706c */
        l_0x1008_7043:
            ii(0x1008_7043, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_7046, 5);  call(0x1007_63a0, -0x1_0cab);         /* call 0x100763a0 */
            ii(0x1008_704b, 5);  call(0x1015_287d, 0xc_b82d);          /* call 0x1015287d */
            ii(0x1008_7050, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_7053, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_7056, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_7059, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_705c, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_705f, 5);  call(0x1007_63d4, -0x1_0c90);         /* call 0x100763d4 */
            ii(0x1008_7064, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_7066, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1008_7069, 3);  call_abs(memd[ds, ebx + 44]);         /* call dword [ebx+0x2c] */
        l_0x1008_706c:
            ii(0x1008_706c, 5);  jmp(0x1008_6eff, -0x172); goto l_0x1008_6eff;/* jmp 0x10086eff */
        l_0x1008_7071:
            ii(0x1008_7071, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_7073, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1008_7076, 5);  call(0x1007_5f6c, -0x1_110f);         /* call 0x10075f6c */
            ii(0x1008_707b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_707d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_707e, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_707f, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_7080, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_7081, 1);  ret();                                /* ret */
        }
    }
}
