using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d472-15d8ca0d")]
        public void Method_1011_d472()
        {
            ii(0x1011_d472, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1011_d477, 5);  call(Definitions.sys_check_available_stack_size, 0x4_88d6);/* call 0x10165d52 */
            ii(0x1011_d47c, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_d47d, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_d47e, 1);  push(esi);                            /* push esi */
            ii(0x1011_d47f, 1);  push(edi);                            /* push edi */
            ii(0x1011_d480, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_d481, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_d483, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1011_d489, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_d48c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_d48f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d492, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d495, 5);  call(0x1007_6574, -0xa_6f26);         /* call 0x10076574 */
            ii(0x1011_d49a, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1011_d49d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1011_d4a2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_d4a4, 2);  if(jle(0x1011_d4f0, 0x4a)) goto l_0x1011_d4f0;/* jle 0x1011d4f0 */
            ii(0x1011_d4a6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d4a9, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d4ac, 5);  call(0x1007_6574, -0xa_6f3d);         /* call 0x10076574 */
            ii(0x1011_d4b1, 4);  cmp(memb[ds, eax + 61], 2);           /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1011_d4b5, 2);  if(jz(0x1011_d4c8, 0x11)) goto l_0x1011_d4c8;/* jz 0x1011d4c8 */
            ii(0x1011_d4b7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d4ba, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d4bd, 5);  call(0x1007_6574, -0xa_6f4e);         /* call 0x10076574 */
            ii(0x1011_d4c2, 4);  cmp(memb[ds, eax + 61], 0x1b);        /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1011_d4c6, 2);  if(jnz(0x1011_d4ca, 2)) goto l_0x1011_d4ca;/* jnz 0x1011d4ca */
        l_0x1011_d4c8:
            ii(0x1011_d4c8, 2);  jmp(0x1011_d4db, 0x11); goto l_0x1011_d4db;/* jmp 0x1011d4db */
        l_0x1011_d4ca:
            ii(0x1011_d4ca, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d4cd, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d4d0, 5);  call(0x1007_6574, -0xa_6f61);         /* call 0x10076574 */
            ii(0x1011_d4d5, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1011_d4d9, 2);  if(jnz(0x1011_d4dd, 2)) goto l_0x1011_d4dd;/* jnz 0x1011d4dd */
        l_0x1011_d4db:
            ii(0x1011_d4db, 2);  jmp(0x1011_d4ee, 0x11); goto l_0x1011_d4ee;/* jmp 0x1011d4ee */
        l_0x1011_d4dd:
            ii(0x1011_d4dd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d4e0, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d4e3, 5);  call(0x1007_6574, -0xa_6f74);         /* call 0x10076574 */
            ii(0x1011_d4e8, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1011_d4ec, 2);  if(jnz(0x1011_d4f0, 2)) goto l_0x1011_d4f0;/* jnz 0x1011d4f0 */
        l_0x1011_d4ee:
            ii(0x1011_d4ee, 2);  jmp(0x1011_d4f2, 2); goto l_0x1011_d4f2;/* jmp 0x1011d4f2 */
        l_0x1011_d4f0:
            ii(0x1011_d4f0, 2);  jmp(0x1011_d516, 0x24); goto l_0x1011_d516;/* jmp 0x1011d516 */
        l_0x1011_d4f2:
            ii(0x1011_d4f2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d4f5, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d4f8, 5);  call(0x1007_6574, -0xa_6f89);         /* call 0x10076574 */
            ii(0x1011_d4fd, 4);  cmp(memb[ds, eax + 62], 0x2a);        /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1011_d501, 2);  if(jz(0x1011_d514, 0x11)) goto l_0x1011_d514;/* jz 0x1011d514 */
            ii(0x1011_d503, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d506, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d509, 5);  call(0x1007_6574, -0xa_6f9a);         /* call 0x10076574 */
            ii(0x1011_d50e, 4);  cmp(memb[ds, eax + 62], 0x1d);        /* cmp byte [eax+0x3e], 0x1d */
            ii(0x1011_d512, 2);  if(jnz(0x1011_d516, 2)) goto l_0x1011_d516;/* jnz 0x1011d516 */
        l_0x1011_d514:
            ii(0x1011_d514, 2);  jmp(0x1011_d51b, 5); goto l_0x1011_d51b;/* jmp 0x1011d51b */
        l_0x1011_d516:
            ii(0x1011_d516, 5);  jmp(0x1011_d7f9, 0x2de); goto l_0x1011_d7f9;/* jmp 0x1011d7f9 */
        l_0x1011_d51b:
            ii(0x1011_d51b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d51e, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d521, 5);  call(0x1007_6574, -0xa_6fb2);         /* call 0x10076574 */
            ii(0x1011_d526, 3);  mov(al, memb[ds, eax + 62]);          /* mov al, [eax+0x3e] */
            ii(0x1011_d529, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1011_d52c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_d52f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d532, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d535, 5);  call(0x1007_6574, -0xa_6fc6);         /* call 0x10076574 */
            ii(0x1011_d53a, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1011_d53d, 5);  call(0x1007_6a34, -0xa_6b0e);         /* call 0x10076a34 */
            ii(0x1011_d542, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d545, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d548, 5);  call(0x1007_6574, -0xa_6fd9);         /* call 0x10076574 */
            ii(0x1011_d54d, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1011_d551, 2);  if(jnz(0x1011_d559, 6)) goto l_0x1011_d559;/* jnz 0x1011d559 */
            ii(0x1011_d553, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1011_d557, 2);  if(jnz(0x1011_d55b, 2)) goto l_0x1011_d55b;/* jnz 0x1011d55b */
        l_0x1011_d559:
            ii(0x1011_d559, 2);  jmp(0x1011_d56e, 0x13); goto l_0x1011_d56e;/* jmp 0x1011d56e */
        l_0x1011_d55b:
            ii(0x1011_d55b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_d55e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d561, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d564, 5);  call(0x1007_65d0, -0xa_6f99);         /* call 0x100765d0 */
            ii(0x1011_d569, 5);  call(0x1011_d292, -0x2dc);            /* call 0x1011d292 */
        l_0x1011_d56e:
            ii(0x1011_d56e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_d570, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d573, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d576, 5);  call(0x1007_6574, -0xa_7007);         /* call 0x10076574 */
            ii(0x1011_d57b, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x1011_d57e, 5);  call(0x1013_ad11, 0x1_d78e);          /* call 0x1013ad11 */
            ii(0x1011_d583, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_d585, 6);  if(jz(0x1011_d6dd, 0x152)) goto l_0x1011_d6dd;/* jz 0x1011d6dd */
            ii(0x1011_d58b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d58e, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d591, 5);  call(0x1007_6574, -0xa_7022);         /* call 0x10076574 */
            ii(0x1011_d596, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1011_d59a, 6);  if(jnz(0x1011_d651, 0xb1)) goto l_0x1011_d651;/* jnz 0x1011d651 */
            ii(0x1011_d5a0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d5a3, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d5a6, 5);  call(0x1007_6574, -0xa_7037);         /* call 0x10076574 */
            ii(0x1011_d5ab, 5);  call(0x1007_623c, -0xa_7374);         /* call 0x1007623c */
            ii(0x1011_d5b0, 3);  mov(edx, memd[ds, eax + 16]);         /* mov edx, [eax+0x10] */
            ii(0x1011_d5b3, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_d5b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d5b9, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d5bc, 5);  call(0x1007_6574, -0xa_704d);         /* call 0x10076574 */
            ii(0x1011_d5c1, 5);  call(0x1007_623c, -0xa_738a);         /* call 0x1007623c */
            ii(0x1011_d5c6, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1011_d5c9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_d5cc, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1011_d5cf, 2);  mov(ecx, edx);                        /* mov ecx, edx */
            ii(0x1011_d5d1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d5d4, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d5d7, 5);  call(0x1007_6574, -0xa_7068);         /* call 0x10076574 */
            ii(0x1011_d5dc, 3);  mov(ebx, memd[ds, eax + 65]);         /* mov ebx, [eax+0x41] */
            ii(0x1011_d5df, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_d5e2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d5e5, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d5e8, 5);  call(0x1007_6574, -0xa_7079);         /* call 0x10076574 */
            ii(0x1011_d5ed, 3);  mov(edx, memd[ds, eax + 63]);         /* mov edx, [eax+0x3f] */
            ii(0x1011_d5f0, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_d5f3, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_d5f6, 5);  call(0x1007_6aac, -0xa_6b4f);         /* call 0x10076aac */
            ii(0x1011_d5fb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_d5fd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d600, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d603, 5);  call(0x1007_65d0, -0xa_7038);         /* call 0x100765d0 */
            ii(0x1011_d608, 5);  call(0x1007_0ca1, -0xa_c96c);         /* call 0x10070ca1 */
            ii(0x1011_d60d, 1);  cwde();                               /* cwde */
            ii(0x1011_d60e, 2);  cmp(eax, ecx);                        /* cmp eax, ecx */
            ii(0x1011_d610, 2);  if(jg(0x1011_d651, 0x3f)) goto l_0x1011_d651;/* jg 0x1011d651 */
            ii(0x1011_d612, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1011_d617, 5);  mov(edx, 0x1e);                       /* mov edx, 0x1e */
            ii(0x1011_d61c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d61f, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d622, 5);  call(0x1007_65d0, -0xa_7057);         /* call 0x100765d0 */
            ii(0x1011_d627, 5);  call(0x1016_3053, 0x4_5a27);          /* call 0x10163053 */
            ii(0x1011_d62c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d62f, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d632, 5);  call(0x1007_6574, -0xa_70c3);         /* call 0x10076574 */
            ii(0x1011_d637, 5);  call(0x1014_9fa8, 0x2_c96c);          /* call 0x10149fa8 */
            ii(0x1011_d63c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d63f, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d642, 5);  call(0x1007_65d0, -0xa_7077);         /* call 0x100765d0 */
            ii(0x1011_d647, 5);  call(0x1007_5a79, -0xa_7bd3);         /* call 0x10075a79 */
            ii(0x1011_d64c, 5);  jmp(0x1011_d7f9, 0x1a8); goto l_0x1011_d7f9;/* jmp 0x1011d7f9 */
        l_0x1011_d651:
            ii(0x1011_d651, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_d653, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d656, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d659, 5);  call(0x1007_6574, -0xa_70ea);         /* call 0x10076574 */
            ii(0x1011_d65e, 5);  call(0x1014_f017, 0x3_19b4);          /* call 0x1014f017 */
            ii(0x1011_d663, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_d66a, 2);  if(jz(0x1011_d67c, 0x10)) goto l_0x1011_d67c;/* jz 0x1011d67c */
            ii(0x1011_d66c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d66f, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d672, 5);  call(0x1007_65d0, -0xa_70a7);         /* call 0x100765d0 */
            ii(0x1011_d677, 5);  call(0x1012_b020, 0xd9a4);            /* call 0x1012b020 */
        l_0x1011_d67c:
            ii(0x1011_d67c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d67f, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d682, 5);  call(0x1007_6574, -0xa_7113);         /* call 0x10076574 */
            ii(0x1011_d687, 5);  call(0x1007_61d4, -0xa_74b8);         /* call 0x100761d4 */
            ii(0x1011_d68c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_d68e, 2);  if(jz(0x1011_d696, 6)) goto l_0x1011_d696;/* jz 0x1011d696 */
            ii(0x1011_d690, 4);  cmp(memb[ss, ebp - 12], 0x2a);        /* cmp byte [ebp-0xc], 0x2a */
            ii(0x1011_d694, 2);  if(jz(0x1011_d698, 2)) goto l_0x1011_d698;/* jz 0x1011d698 */
        l_0x1011_d696:
            ii(0x1011_d696, 2);  jmp(0x1011_d6a8, 0x10); goto l_0x1011_d6a8;/* jmp 0x1011d6a8 */
        l_0x1011_d698:
            ii(0x1011_d698, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d69b, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d69e, 5);  call(0x1007_6574, -0xa_712f);         /* call 0x10076574 */
            ii(0x1011_d6a3, 5);  call(0x1014_b6bd, 0x2_e015);          /* call 0x1014b6bd */
        l_0x1011_d6a8:
            ii(0x1011_d6a8, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x1011_d6ad, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d6b0, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d6b3, 5);  call(0x1008_b530, -0x9_2188);         /* call 0x1008b530 */
            ii(0x1011_d6b8, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_d6ba, 2);  if(jz(0x1011_d6d8, 0x1c)) goto l_0x1011_d6d8;/* jz 0x1011d6d8 */
            ii(0x1011_d6bc, 5);  call(0x100d_5470, -0x4_8251);         /* call 0x100d5470 */
            ii(0x1011_d6c1, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1011_d6c4, 5);  mov(ebx, 0x3e9);                      /* mov ebx, 0x3e9 */
            ii(0x1011_d6c9, 5);  mov(edx, 0x3e6);                      /* mov edx, 0x3e6 */
            ii(0x1011_d6ce, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x1011_d6d3, 5);  call(0x1013_daea, 0x2_0412);          /* call 0x1013daea */
        l_0x1011_d6d8:
            ii(0x1011_d6d8, 5);  jmp(0x1011_d7f9, 0x11c); goto l_0x1011_d7f9;/* jmp 0x1011d7f9 */
        l_0x1011_d6dd:
            ii(0x1011_d6dd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d6e0, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d6e3, 5);  call(0x1007_6574, -0xa_7174);         /* call 0x10076574 */
            ii(0x1011_d6e8, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1011_d6ec, 2);  if(jnz(0x1011_d71c, 0x2e)) goto l_0x1011_d71c;/* jnz 0x1011d71c */
            ii(0x1011_d6ee, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_d6f5, 2);  if(jz(0x1011_d707, 0x10)) goto l_0x1011_d707;/* jz 0x1011d707 */
            ii(0x1011_d6f7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d6fa, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d6fd, 5);  call(0x1007_65d0, -0xa_7132);         /* call 0x100765d0 */
            ii(0x1011_d702, 5);  call(0x1012_ae8d, 0xd786);            /* call 0x1012ae8d */
        l_0x1011_d707:
            ii(0x1011_d707, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d70a, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d70d, 5);  call(0x1008_abbc, -0x9_2b56);         /* call 0x1008abbc */
            ii(0x1011_d712, 5);  call(0x1016_3378, 0x4_5c61);          /* call 0x10163378 */
            ii(0x1011_d717, 5);  jmp(0x1011_d7f9, 0xdd); goto l_0x1011_d7f9;/* jmp 0x1011d7f9 */
        l_0x1011_d71c:
            ii(0x1011_d71c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d71f, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d722, 5);  call(0x1007_6574, -0xa_71b3);         /* call 0x10076574 */
            ii(0x1011_d727, 4);  cmp(memb[ds, eax + 62], 0x1d);        /* cmp byte [eax+0x3e], 0x1d */
            ii(0x1011_d72b, 2);  if(jnz(0x1011_d782, 0x55)) goto l_0x1011_d782;/* jnz 0x1011d782 */
            ii(0x1011_d72d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d730, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d733, 5);  call(0x1007_6574, -0xa_71c4);         /* call 0x10076574 */
            ii(0x1011_d738, 4);  cmp(memb[ds, eax + 61], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1011_d73c, 2);  if(jnz(0x1011_d74f, 0x11)) goto l_0x1011_d74f;/* jnz 0x1011d74f */
            ii(0x1011_d73e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d741, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d744, 5);  call(0x1007_6574, -0xa_71d5);         /* call 0x10076574 */
            ii(0x1011_d749, 4);  mov(memb[ds, eax + 62], 1);           /* mov byte [eax+0x3e], 0x1 */
            ii(0x1011_d74d, 2);  jmp(0x1011_d75f, 0x10); goto l_0x1011_d75f;/* jmp 0x1011d75f */
        l_0x1011_d74f:
            ii(0x1011_d74f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d752, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d755, 5);  call(0x1007_6574, -0xa_71e6);         /* call 0x10076574 */
            ii(0x1011_d75a, 5);  call(0x1014_f08b, 0x3_192c);          /* call 0x1014f08b */
        l_0x1011_d75f:
            ii(0x1011_d75f, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_d766, 2);  if(jz(0x1011_d778, 0x10)) goto l_0x1011_d778;/* jz 0x1011d778 */
            ii(0x1011_d768, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d76b, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d76e, 5);  call(0x1007_65d0, -0xa_71a3);         /* call 0x100765d0 */
            ii(0x1011_d773, 5);  call(0x1012_ae8d, 0xd715);            /* call 0x1012ae8d */
        l_0x1011_d778:
            ii(0x1011_d778, 5);  call(0x100f_f5c1, -0x1_e1bc);         /* call 0x100ff5c1 */
            ii(0x1011_d77d, 5);  jmp(0x1011_d7f9, 0x77); goto l_0x1011_d7f9;/* jmp 0x1011d7f9 */
        l_0x1011_d782:
            ii(0x1011_d782, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d785, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d788, 5);  call(0x1007_6574, -0xa_7219);         /* call 0x10076574 */
            ii(0x1011_d78d, 5);  call(0x1007_61d4, -0xa_75be);         /* call 0x100761d4 */
            ii(0x1011_d792, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_d794, 2);  if(jz(0x1011_d7c1, 0x2b)) goto l_0x1011_d7c1;/* jz 0x1011d7c1 */
            ii(0x1011_d796, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_d79d, 2);  if(jz(0x1011_d7af, 0x10)) goto l_0x1011_d7af;/* jz 0x1011d7af */
            ii(0x1011_d79f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d7a2, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d7a5, 5);  call(0x1007_65d0, -0xa_71da);         /* call 0x100765d0 */
            ii(0x1011_d7aa, 5);  call(0x1012_ae8d, 0xd6de);            /* call 0x1012ae8d */
        l_0x1011_d7af:
            ii(0x1011_d7af, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d7b2, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d7b5, 5);  call(0x1007_65d0, -0xa_71ea);         /* call 0x100765d0 */
            ii(0x1011_d7ba, 5);  call(0x1007_5a79, -0xa_7d46);         /* call 0x10075a79 */
            ii(0x1011_d7bf, 2);  jmp(0x1011_d7f9, 0x38); goto l_0x1011_d7f9;/* jmp 0x1011d7f9 */
        l_0x1011_d7c1:
            ii(0x1011_d7c1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d7c4, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d7c7, 5);  call(0x1007_6574, -0xa_7258);         /* call 0x10076574 */
            ii(0x1011_d7cc, 5);  call(0x1015_48ba, 0x3_70e9);          /* call 0x101548ba */
            ii(0x1011_d7d1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d7d4, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d7d7, 5);  call(0x1007_6574, -0xa_7268);         /* call 0x10076574 */
            ii(0x1011_d7dc, 4);  mov(memb[ds, eax + 62], 5);           /* mov byte [eax+0x3e], 0x5 */
            ii(0x1011_d7e0, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_d7e7, 2);  if(jz(0x1011_d7f9, 0x10)) goto l_0x1011_d7f9;/* jz 0x1011d7f9 */
            ii(0x1011_d7e9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_d7ec, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1011_d7ef, 5);  call(0x1007_65d0, -0xa_7224);         /* call 0x100765d0 */
            ii(0x1011_d7f4, 5);  call(0x1012_ae8d, 0xd694);            /* call 0x1012ae8d */
        l_0x1011_d7f9:
            ii(0x1011_d7f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_d7fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_d7fc, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_d7fd, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_d7fe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_d7ff, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_d800, 1);  ret();                                /* ret */
        }
    }
}
