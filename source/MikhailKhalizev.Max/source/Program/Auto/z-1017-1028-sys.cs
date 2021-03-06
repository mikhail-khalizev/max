using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_1028-5073fd5")]
        public void /* sys */ Method_1017_1028()
        {
            ii(0x1017_1028, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_1029, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_102a, 1);  push(esi);                            /* push esi */
            ii(0x1017_102b, 1);  push(edi);                            /* push edi */
            ii(0x1017_102c, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_102d, 3);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1017_1030, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1017_1032, 2);  mov(ebp, edx);                        /* mov ebp, edx */
            ii(0x1017_1034, 5);  mov(eax, memd[ds, 0x101b_e1c0]);      /* mov eax, [0x101be1c0] */
            ii(0x1017_1039, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1017_103c, 6);  if(jz(0x1017_1113, 0xd1)) goto l_0x1017_1113;/* jz 0x10171113 */
            ii(0x1017_1042, 2);  test(esi, esi);                       /* test esi, esi */
            ii(0x1017_1044, 6);  if(jz(0x1017_1113, 0xc9)) goto l_0x1017_1113;/* jz 0x10171113 */
            ii(0x1017_104a, 2);  test(ebp, ebp);                       /* test ebp, ebp */
            ii(0x1017_104c, 6);  if(jz(0x1017_1113, 0xc1)) goto l_0x1017_1113;/* jz 0x10171113 */
            ii(0x1017_1052, 3);  cmp(memb[ds, esi], 0x2e);             /* cmp byte [esi], 0x2e */
            ii(0x1017_1055, 2);  if(jnz(0x1017_1061, 0xa)) goto l_0x1017_1061;/* jnz 0x10171061 */
            ii(0x1017_1057, 3);  mov(dl, memb[ds, esi + 1]);           /* mov dl, [esi+0x1] */
            ii(0x1017_105a, 1);  inc(esi);                             /* inc esi */
            ii(0x1017_105b, 3);  cmp(dl, 0x5c);                        /* cmp dl, 0x5c */
            ii(0x1017_105e, 2);  if(jnz(0x1017_1061, 1)) goto l_0x1017_1061;/* jnz 0x10171061 */
            ii(0x1017_1060, 1);  inc(esi);                             /* inc esi */
        l_0x1017_1061:
            ii(0x1017_1061, 2);  mov(edi, esi);                        /* mov edi, esi */
            ii(0x1017_1063, 2);  sub(ecx, ecx);                        /* sub ecx, ecx */
            ii(0x1017_1065, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_1066, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_1068, 2);  repne(() => scasb());                 /* repne scasb */
            ii(0x1017_106a, 2);  not(ecx);                             /* not ecx */
            ii(0x1017_106c, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_106d, 3);  lea(ebx, memd[ds, ecx - 1]);          /* lea ebx, [ecx-0x1] */
            ii(0x1017_1070, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1017_1072, 2);  if(jge(0x1017_107e, 0xa)) goto l_0x1017_107e;/* jge 0x1017107e */
            ii(0x1017_1074, 2);  jmp(0x1017_1086, 0x10); goto l_0x1017_1086;/* jmp 0x10171086 */
        l_0x1017_1076:
            ii(0x1017_1076, 1);  dec(ebx);                             /* dec ebx */
            ii(0x1017_1077, 1);  dec(eax);                             /* dec eax */
            ii(0x1017_1078, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1017_107a, 2);  if(jge(0x1017_1081, 5)) goto l_0x1017_1081;/* jge 0x10171081 */
            ii(0x1017_107c, 2);  jmp(0x1017_1086, 8); goto l_0x1017_1086;/* jmp 0x10171086 */
        l_0x1017_107e:
            ii(0x1017_107e, 3);  lea(eax, memd[ds, ebx + esi]);        /* lea eax, [ebx+esi] */
        l_0x1017_1081:
            ii(0x1017_1081, 3);  cmp(memb[ds, eax], 0x5c);             /* cmp byte [eax], 0x5c */
            ii(0x1017_1084, 2);  if(jnz(0x1017_1076, -0x10)) goto l_0x1017_1076;/* jnz 0x10171076 */
        l_0x1017_1086:
            ii(0x1017_1086, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1017_1088, 2);  if(jl(0x1017_10a1, 0x17)) goto l_0x1017_10a1;/* jl 0x101710a1 */
            ii(0x1017_108a, 5);  mov(eax, memd[ds, 0x101b_e1c0]);      /* mov eax, [0x101be1c0] */
            ii(0x1017_108f, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1017_1091, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1017_1094, 4);  mov(memb[ds, esi + ebx], 0);          /* mov byte [esi+ebx], 0x0 */
            ii(0x1017_1098, 5);  call(/* sys */ 0x1018_b764, 0x1_a6c7);/* call 0x1018b764 */
            ii(0x1017_109d, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1017_109f, 2);  jmp(0x1017_10a3, 2); goto l_0x1017_10a3;/* jmp 0x101710a3 */
        l_0x1017_10a1:
            ii(0x1017_10a1, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
        l_0x1017_10a3:
            ii(0x1017_10a3, 3);  cmp(ecx, -1 /* 0xff */);              /* cmp ecx, 0xffffffff */
            ii(0x1017_10a6, 2);  if(jz(0x1017_110b, 0x63)) goto l_0x1017_110b;/* jz 0x1017110b */
            ii(0x1017_10a8, 3);  lea(edi, memd[ds, esi + ebx]);        /* lea edi, [esi+ebx] */
            ii(0x1017_10ab, 3);  lea(eax, memd[ds, edi + 1]);          /* lea eax, [edi+0x1] */
            ii(0x1017_10ae, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
            ii(0x1017_10b1, 7);  lea(eax, memd[ds, ecx * 8]);          /* lea eax, [ecx*8] */
            ii(0x1017_10b8, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x1017_10ba, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1017_10bd, 6);  mov(edx, memd[ds, 0x101b_e1c0]);      /* mov edx, [0x101be1c0] */
            ii(0x1017_10c3, 4);  mov(memd[ss, esp + 4], eax);          /* mov [esp+0x4], eax */
            ii(0x1017_10c7, 3);  mov(eax, memd[ds, edx + 56]);         /* mov eax, [edx+0x38] */
            ii(0x1017_10ca, 4);  add(eax, memd[ss, esp + 4]);          /* add eax, [esp+0x4] */
            ii(0x1017_10ce, 3);  mov(edx, memd[ss, esp]);              /* mov edx, [esp] */
            ii(0x1017_10d1, 5);  call(/* sys */ 0x1018_b764, 0x1_a68e);/* call 0x1018b764 */
            ii(0x1017_10d6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_10d8, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_10db, 2);  if(jz(0x1017_110b, 0x2e)) goto l_0x1017_110b;/* jz 0x1017110b */
            ii(0x1017_10dd, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1017_10df, 2);  if(jl(0x1017_10e4, 3)) goto l_0x1017_10e4;/* jl 0x101710e4 */
            ii(0x1017_10e1, 3);  mov(memb[ds, edi], 0x5c);             /* mov byte [edi], 0x5c */
        l_0x1017_10e4:
            ii(0x1017_10e4, 7);  lea(ebx, memd[ds, ecx * 8]);          /* lea ebx, [ecx*8] */
            ii(0x1017_10eb, 6);  mov(esi, memd[ds, 0x101b_e1c0]);      /* mov esi, [0x101be1c0] */
            ii(0x1017_10f1, 2);  add(ebx, ecx);                        /* add ebx, ecx */
            ii(0x1017_10f3, 3);  mov(eax, memd[ds, esi + 56]);         /* mov eax, [esi+0x38] */
            ii(0x1017_10f6, 3);  shl(ebx, 2);                          /* shl ebx, 0x2 */
            ii(0x1017_10f9, 4);  mov(eax, memd[ds, ebx + eax + 32]);   /* mov eax, [ebx+eax+0x20] */
            ii(0x1017_10fd, 2);  mov(edi, ebp);                        /* mov edi, ebp */
            ii(0x1017_10ff, 4);  mov(esi, memd[ds, eax + edx * 8 + 4]);/* mov esi, [eax+edx*8+0x4] */
            ii(0x1017_1103, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_1105, 1);  movsd();                              /* movsd */
            ii(0x1017_1106, 1);  movsd();                              /* movsd */
            ii(0x1017_1107, 1);  movsd();                              /* movsd */
            ii(0x1017_1108, 1);  movsd();                              /* movsd */
            ii(0x1017_1109, 2);  jmp(0x1017_1118, 0xd); goto l_0x1017_1118;/* jmp 0x10171118 */
        l_0x1017_110b:
            ii(0x1017_110b, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1017_110d, 2);  if(jl(0x1017_1113, 4)) goto l_0x1017_1113;/* jl 0x10171113 */
            ii(0x1017_110f, 4);  mov(memb[ds, esi + ebx], 0x5c);       /* mov byte [esi+ebx], 0x5c */
        l_0x1017_1113:
            ii(0x1017_1113, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
        l_0x1017_1118:
            ii(0x1017_1118, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1017_111b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_111c, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_111d, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_111e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_111f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_1120, 1);  ret();                                /* ret */
        }
    }
}
