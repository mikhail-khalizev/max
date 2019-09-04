using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_e7e0-8358a93d")]
        public void Method_1008_e7e0()
        {
            ii(0x1008_e7e0, 5);  push(0x60);                           /* push 0x60 */
            ii(0x1008_e7e5, 5);  call(Definitions.sys_check_available_stack_size, 0xd_7568);/* call 0x10165d52 */
            ii(0x1008_e7ea, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_e7eb, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_e7ec, 1);  push(esi);                            /* push esi */
            ii(0x1008_e7ed, 1);  push(edi);                            /* push edi */
            ii(0x1008_e7ee, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_e7ef, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_e7f1, 6);  sub(esp, 0x48);                       /* sub esp, 0x48 */
            ii(0x1008_e7f7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_e7fa, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_e7fd, 5);  mov(eax, memd[ds, 0x101c_9454]);      /* mov eax, [0x101c9454] */
            ii(0x1008_e802, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_e805, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1008_e80a, 5);  call(0x1007_6338, -0x1_84d7);         /* call 0x10076338 */
            ii(0x1008_e80f, 3);  lea(ebx, memd[ss, ebp - 36]);         /* lea ebx, [ebp-0x24] */
            ii(0x1008_e812, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_e814, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_e816, 5);  call(0x1007_64b8, -0x1_8363);         /* call 0x100764b8 */
            ii(0x1008_e81b, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1008_e822, 2);  jmp(0x1008_e82a, 6); goto l_0x1008_e82a;/* jmp 0x1008e82a */
        l_0x1008_e824:
            ii(0x1008_e824, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_e827, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1008_e82a:
            ii(0x1008_e82a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_e82d, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_e834, 6);  if(jge(0x1008_e8d7, 0x9d)) goto l_0x1008_e8d7;/* jge 0x1008e8d7 */
            ii(0x1008_e83a, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_e841, 2);  jmp(0x1008_e849, 6); goto l_0x1008_e849;/* jmp 0x1008e849 */
        l_0x1008_e843:
            ii(0x1008_e843, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_e846, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1008_e849:
            ii(0x1008_e849, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_e84c, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_e853, 6);  if(jge(0x1008_e8d2, 0x79)) goto l_0x1008_e8d2;/* jge 0x1008e8d2 */
            ii(0x1008_e859, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_e85c, 3);  inc(memd[ss, ebp - 32]);              /* inc dword [ebp-0x20] */
            ii(0x1008_e85f, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1008_e861, 3);  mov(memb[ss, ebp - 40], al);          /* mov [ebp-0x28], al */
            ii(0x1008_e864, 2);  jmp(0x1008_e8ab, 0x45); goto l_0x1008_e8ab;/* jmp 0x1008e8ab */
        l_0x1008_e866:
            ii(0x1008_e866, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e86a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e86d, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_e870, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_e874, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e876, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e878, 3);  mov(memb[ds, eax], 2);                /* mov byte [eax], 0x2 */
            ii(0x1008_e87b, 2);  jmp(0x1008_e8cd, 0x50); goto l_0x1008_e8cd;/* jmp 0x1008e8cd */
        l_0x1008_e87d:
            ii(0x1008_e87d, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e881, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e884, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_e887, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_e88b, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e88d, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e88f, 3);  mov(memb[ds, eax], 1);                /* mov byte [eax], 0x1 */
            ii(0x1008_e892, 2);  jmp(0x1008_e8cd, 0x39); goto l_0x1008_e8cd;/* jmp 0x1008e8cd */
        l_0x1008_e894:
            ii(0x1008_e894, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e898, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e89b, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_e89e, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_e8a2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e8a4, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e8a6, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1008_e8a9, 2);  jmp(0x1008_e8cd, 0x22); goto l_0x1008_e8cd;/* jmp 0x1008e8cd */
        l_0x1008_e8ab:
            ii(0x1008_e8ab, 3);  mov(al, memb[ss, ebp - 40]);          /* mov al, [ebp-0x28] */
            ii(0x1008_e8ae, 3);  mov(memb[ss, ebp - 44], al);          /* mov [ebp-0x2c], al */
            ii(0x1008_e8b1, 4);  cmp(memb[ss, ebp - 44], 2);           /* cmp byte [ebp-0x2c], 0x2 */
            ii(0x1008_e8b5, 2);  if(jb(0x1008_e8c5, 0xe)) goto l_0x1008_e8c5;/* jb 0x1008e8c5 */
            ii(0x1008_e8b7, 4);  cmp(memb[ss, ebp - 44], 2);           /* cmp byte [ebp-0x2c], 0x2 */
            ii(0x1008_e8bb, 2);  if(jbe(0x1008_e87d, -0x40)) goto l_0x1008_e87d;/* jbe 0x1008e87d */
            ii(0x1008_e8bd, 4);  cmp(memb[ss, ebp - 44], 4);           /* cmp byte [ebp-0x2c], 0x4 */
            ii(0x1008_e8c1, 2);  if(jz(0x1008_e87d, -0x46)) goto l_0x1008_e87d;/* jz 0x1008e87d */
            ii(0x1008_e8c3, 2);  jmp(0x1008_e894, -0x31); goto l_0x1008_e894;/* jmp 0x1008e894 */
        l_0x1008_e8c5:
            ii(0x1008_e8c5, 4);  cmp(memb[ss, ebp - 44], 1);           /* cmp byte [ebp-0x2c], 0x1 */
            ii(0x1008_e8c9, 2);  if(jz(0x1008_e866, -0x65)) goto l_0x1008_e866;/* jz 0x1008e866 */
            ii(0x1008_e8cb, 2);  jmp(0x1008_e894, -0x39); goto l_0x1008_e894;/* jmp 0x1008e894 */
        l_0x1008_e8cd:
            ii(0x1008_e8cd, 5);  jmp(0x1008_e843, -0x8f); goto l_0x1008_e843;/* jmp 0x1008e843 */
        l_0x1008_e8d2:
            ii(0x1008_e8d2, 5);  jmp(0x1008_e824, -0xb3); goto l_0x1008_e824;/* jmp 0x1008e824 */
        l_0x1008_e8d7:
            ii(0x1008_e8d7, 2);  jmp(0x1008_e8e1, 8); goto l_0x1008_e8e1;/* jmp 0x1008e8e1 */
        l_0x1008_e8d9:
            ii(0x1008_e8d9, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_e8dc, 5);  call(0x1007_6bf8, -0x1_7ce9);         /* call 0x10076bf8 */
        l_0x1008_e8e1:
            ii(0x1008_e8e1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_e8e3, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_e8e6, 5);  call(0x1013_ad71, 0xa_c486);          /* call 0x1013ad71 */
            ii(0x1008_e8eb, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_e8ed, 6);  if(jz(0x1008_e95e, 0x6b)) goto l_0x1008_e95e;/* jz 0x1008e95e */
            ii(0x1008_e8f3, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_e8f6, 5);  call(0x1007_63a0, -0x1_855b);         /* call 0x100763a0 */
            ii(0x1008_e8fb, 5);  cmp(memw[ds, eax + 8], 0xc);          /* cmp word [eax+0x8], 0xc */
            ii(0x1008_e900, 2);  if(jz(0x1008_e959, 0x57)) goto l_0x1008_e959;/* jz 0x1008e959 */
            ii(0x1008_e902, 3);  lea(edx, memd[ss, ebp - 60]);         /* lea edx, [ebp-0x3c] */
            ii(0x1008_e905, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_e908, 5);  call(0x1007_63a0, -0x1_856d);         /* call 0x100763a0 */
            ii(0x1008_e90d, 5);  call(0x1015_2532, 0xc_3c20);          /* call 0x10152532 */
            ii(0x1008_e912, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_e915, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_e918, 2);  jmp(0x1008_e920, 6); goto l_0x1008_e920;/* jmp 0x1008e920 */
        l_0x1008_e91a:
            ii(0x1008_e91a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_e91d, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1008_e920:
            ii(0x1008_e920, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e924, 3);  cmp(eax, memd[ss, ebp - 52]);         /* cmp eax, [ebp-0x34] */
            ii(0x1008_e927, 2);  if(jge(0x1008_e959, 0x30)) goto l_0x1008_e959;/* jge 0x1008e959 */
            ii(0x1008_e929, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_e92c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_e92f, 2);  jmp(0x1008_e937, 6); goto l_0x1008_e937;/* jmp 0x1008e937 */
        l_0x1008_e931:
            ii(0x1008_e931, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_e934, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1008_e937:
            ii(0x1008_e937, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1008_e93b, 3);  cmp(eax, memd[ss, ebp - 48]);         /* cmp eax, [ebp-0x30] */
            ii(0x1008_e93e, 2);  if(jge(0x1008_e957, 0x17)) goto l_0x1008_e957;/* jge 0x1008e957 */
            ii(0x1008_e940, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e944, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e947, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_e94a, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_e94e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e950, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e952, 3);  mov(memb[ds, eax], 4);                /* mov byte [eax], 0x4 */
            ii(0x1008_e955, 2);  jmp(0x1008_e931, -0x26); goto l_0x1008_e931;/* jmp 0x1008e931 */
        l_0x1008_e957:
            ii(0x1008_e957, 2);  jmp(0x1008_e91a, -0x3f); goto l_0x1008_e91a;/* jmp 0x1008e91a */
        l_0x1008_e959:
            ii(0x1008_e959, 5);  jmp(0x1008_e8d9, -0x85); goto l_0x1008_e8d9;/* jmp 0x1008e8d9 */
        l_0x1008_e95e:
            ii(0x1008_e95e, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1008_e963, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1008_e968, 5);  mov(edx, 0x3d);                       /* mov edx, 0x3d */
            ii(0x1008_e96d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_e970, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1008_e973, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_e976, 6);  imul(eax, eax, 0xc5);                 /* imul eax, eax, 0xc5 */
            ii(0x1008_e97c, 5);  mov(esi, 0x101c_31c4);                /* mov esi, 0x101c31c4 */
            ii(0x1008_e981, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1008_e983, 5);  call(0x100c_204f, 0x3_36c7);          /* call 0x100c204f */
            ii(0x1008_e988, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1008_e98b, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_e992, 2);  jmp(0x1008_e99a, 6); goto l_0x1008_e99a;/* jmp 0x1008e99a */
        l_0x1008_e994:
            ii(0x1008_e994, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_e997, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1008_e99a:
            ii(0x1008_e99a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_e99d, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_e9a4, 2);  if(jge(0x1008_e9f7, 0x51)) goto l_0x1008_e9f7;/* jge 0x1008e9f7 */
            ii(0x1008_e9a6, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e9aa, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e9ad, 3);  add(eax, memd[ss, ebp - 28]);         /* add eax, [ebp-0x1c] */
            ii(0x1008_e9b0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e9b2, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1008_e9b5, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1008_e9bc, 2);  jmp(0x1008_e9c4, 6); goto l_0x1008_e9c4;/* jmp 0x1008e9c4 */
        l_0x1008_e9be:
            ii(0x1008_e9be, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_e9c1, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1008_e9c4:
            ii(0x1008_e9c4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_e9c7, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_e9ce, 2);  if(jge(0x1008_e9f5, 0x25)) goto l_0x1008_e9f5;/* jge 0x1008e9f5 */
            ii(0x1008_e9d0, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1008_e9d3, 4);  add(memd[ss, ebp - 24], 2);           /* add dword [ebp-0x18], 0x2 */
            ii(0x1008_e9d7, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1008_e9da, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_e9dc, 2);  if(jle(0x1008_e9f3, 0x15)) goto l_0x1008_e9f3;/* jle 0x1008e9f3 */
            ii(0x1008_e9de, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_e9e2, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_e9e5, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_e9e8, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_e9ec, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_e9ee, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_e9f0, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1008_e9f3:
            ii(0x1008_e9f3, 2);  jmp(0x1008_e9be, -0x37); goto l_0x1008_e9be;/* jmp 0x1008e9be */
        l_0x1008_e9f5:
            ii(0x1008_e9f5, 2);  jmp(0x1008_e994, -0x63); goto l_0x1008_e994;/* jmp 0x1008e994 */
        l_0x1008_e9f7:
            ii(0x1008_e9f7, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_e9fc, 5);  call(0x1008_a768, -0x4299);           /* call 0x1008a768 */
            ii(0x1008_ea01, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1008_ea04, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_ea06, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_ea08, 5);  call(0x1008_ae70, -0x3b9d);           /* call 0x1008ae70 */
            ii(0x1008_ea0d, 2);  jmp(0x1008_ea17, 8); goto l_0x1008_ea17;/* jmp 0x1008ea17 */
        l_0x1008_ea0f:
            ii(0x1008_ea0f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ea12, 5);  call(0x1007_6bf8, -0x1_7e1f);         /* call 0x10076bf8 */
        l_0x1008_ea17:
            ii(0x1008_ea17, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_ea19, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ea1c, 5);  call(0x1013_ad71, 0xa_c350);          /* call 0x1013ad71 */
            ii(0x1008_ea21, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_ea23, 6);  if(jz(0x1008_eafb, 0xd2)) goto l_0x1008_eafb;/* jz 0x1008eafb */
            ii(0x1008_ea29, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ea2c, 5);  call(0x1008_adc4, -0x3c6d);           /* call 0x1008adc4 */
            ii(0x1008_ea31, 5);  call(0x1008_ad90, -0x3ca6);           /* call 0x1008ad90 */
            ii(0x1008_ea36, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_ea38, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_ea3b, 4);  cmp(dx, memw[ds, eax + 9]);           /* cmp dx, [eax+0x9] */
            ii(0x1008_ea3f, 2);  if(jnz(0x1008_ea5c, 0x1b)) goto l_0x1008_ea5c;/* jnz 0x1008ea5c */
            ii(0x1008_ea41, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ea44, 5);  call(0x1008_adc4, -0x3c85);           /* call 0x1008adc4 */
            ii(0x1008_ea49, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1008_ea4c, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_ea4f, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_ea52, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1008_ea55, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x1008_ea58, 2);  cmp(al, 9);                           /* cmp al, 0x9 */
            ii(0x1008_ea5a, 2);  if(jz(0x1008_ea61, 5)) goto l_0x1008_ea61;/* jz 0x1008ea61 */
        l_0x1008_ea5c:
            ii(0x1008_ea5c, 5);  jmp(0x1008_eaf6, 0x95); goto l_0x1008_eaf6;/* jmp 0x1008eaf6 */
        l_0x1008_ea61:
            ii(0x1008_ea61, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_ea64, 5);  call(0x1008_adf8, -0x3c71);           /* call 0x1008adf8 */
            ii(0x1008_ea69, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1008_ea6c, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_ea6f, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1008_ea72, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1008_ea75, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_ea78, 3);  lea(edx, memd[ss, ebp - 60]);         /* lea edx, [ebp-0x3c] */
            ii(0x1008_ea7b, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1008_ea7e, 3);  call_abs(memd[ds, ebx + 28]);         /* call dword [ebx+0x1c] */
            ii(0x1008_ea81, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_ea84, 5);  call(0x1009_c4c4, 0xda3b);            /* call 0x1009c4c4 */
            ii(0x1008_ea89, 4);  cmp(ax, 0x27);                        /* cmp ax, 0x27 */
            ii(0x1008_ea8d, 2);  if(jz(0x1008_ea9d, 0xe)) goto l_0x1008_ea9d;/* jz 0x1008ea9d */
            ii(0x1008_ea8f, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_ea92, 5);  call(0x1009_c4c4, 0xda2d);            /* call 0x1009c4c4 */
            ii(0x1008_ea97, 4);  cmp(ax, 0x21);                        /* cmp ax, 0x21 */
            ii(0x1008_ea9b, 2);  if(jnz(0x1008_ea9f, 2)) goto l_0x1008_ea9f;/* jnz 0x1008ea9f */
        l_0x1008_ea9d:
            ii(0x1008_ea9d, 2);  jmp(0x1008_eaad, 0xe); goto l_0x1008_eaad;/* jmp 0x1008eaad */
        l_0x1008_ea9f:
            ii(0x1008_ea9f, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1008_eaa2, 5);  call(0x1009_c4c4, 0xda1d);            /* call 0x1009c4c4 */
            ii(0x1008_eaa7, 4);  cmp(ax, 0xc);                         /* cmp ax, 0xc */
            ii(0x1008_eaab, 2);  if(jnz(0x1008_eaaf, 2)) goto l_0x1008_eaaf;/* jnz 0x1008eaaf */
        l_0x1008_eaad:
            ii(0x1008_eaad, 2);  jmp(0x1008_eaf6, 0x47); goto l_0x1008_eaf6;/* jmp 0x1008eaf6 */
        l_0x1008_eaaf:
            ii(0x1008_eaaf, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1008_eab2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_eab5, 2);  jmp(0x1008_eabd, 6); goto l_0x1008_eabd;/* jmp 0x1008eabd */
        l_0x1008_eab7:
            ii(0x1008_eab7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_eaba, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1008_eabd:
            ii(0x1008_eabd, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_eac1, 3);  cmp(eax, memd[ss, ebp - 52]);         /* cmp eax, [ebp-0x34] */
            ii(0x1008_eac4, 2);  if(jge(0x1008_eaf6, 0x30)) goto l_0x1008_eaf6;/* jge 0x1008eaf6 */
            ii(0x1008_eac6, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_eac9, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_eacc, 2);  jmp(0x1008_ead4, 6); goto l_0x1008_ead4;/* jmp 0x1008ead4 */
        l_0x1008_eace:
            ii(0x1008_eace, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_ead1, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1008_ead4:
            ii(0x1008_ead4, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1008_ead8, 3);  cmp(eax, memd[ss, ebp - 48]);         /* cmp eax, [ebp-0x30] */
            ii(0x1008_eadb, 2);  if(jge(0x1008_eaf4, 0x17)) goto l_0x1008_eaf4;/* jge 0x1008eaf4 */
            ii(0x1008_eadd, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_eae1, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_eae4, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_eae7, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_eaeb, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_eaed, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_eaef, 3);  mov(memb[ds, eax], 4);                /* mov byte [eax], 0x4 */
            ii(0x1008_eaf2, 2);  jmp(0x1008_eace, -0x26); goto l_0x1008_eace;/* jmp 0x1008eace */
        l_0x1008_eaf4:
            ii(0x1008_eaf4, 2);  jmp(0x1008_eab7, -0x3f); goto l_0x1008_eab7;/* jmp 0x1008eab7 */
        l_0x1008_eaf6:
            ii(0x1008_eaf6, 5);  jmp(0x1008_ea0f, -0xec); goto l_0x1008_ea0f;/* jmp 0x1008ea0f */
        l_0x1008_eafb:
            ii(0x1008_eafb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_eafd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1008_eb00, 5);  call(0x1008_8bbc, -0x5f49);           /* call 0x10088bbc */
            ii(0x1008_eb05, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_eb07, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1008_eb0a, 5);  call(0x1007_5f6c, -0x1_8ba3);         /* call 0x10075f6c */
            ii(0x1008_eb0f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_eb11, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_eb12, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_eb13, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_eb14, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_eb15, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_eb16, 1);  ret();                                /* ret */
        }
    }
}
