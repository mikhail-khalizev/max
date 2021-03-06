using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_8cc9-642f99c2")]
        public void Method_1009_8cc9()
        {
            ii(0x1009_8cc9, 5);  push(0x58);                           /* push 0x58 */
            ii(0x1009_8cce, 5);  call(Definitions.sys_check_available_stack_size, 0xc_d07f);/* call 0x10165d52 */
            ii(0x1009_8cd3, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_8cd4, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_8cd5, 1);  push(edx);                            /* push edx */
            ii(0x1009_8cd6, 1);  push(esi);                            /* push esi */
            ii(0x1009_8cd7, 1);  push(edi);                            /* push edi */
            ii(0x1009_8cd8, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_8cd9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_8cdb, 6);  sub(esp, 0x3c);                       /* sub esp, 0x3c */
            ii(0x1009_8ce1, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_8ce4, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1009_8ce7, 5);  call(0x1007_20b1, -0x2_6c3b);         /* call 0x100720b1 */
            ii(0x1009_8cec, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_8cef, 5);  call(0x1007_20b1, -0x2_6c43);         /* call 0x100720b1 */
            ii(0x1009_8cf4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8cf7, 4);  cmp(memb[ds, eax + 29], 2);           /* cmp byte [eax+0x1d], 0x2 */
            ii(0x1009_8cfb, 2);  if(jnz(0x1009_8d06, 9)) goto l_0x1009_8d06;/* jnz 0x10098d06 */
            ii(0x1009_8cfd, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1009_8d04, 2);  jmp(0x1009_8d1f, 0x19); goto l_0x1009_8d1f;/* jmp 0x10098d1f */
        l_0x1009_8d06:
            ii(0x1009_8d06, 5);  mov(ecx, 0x134e);                     /* mov ecx, 0x134e */
            ii(0x1009_8d0b, 5);  mov(ebx, StringDefinitions.AiBuildCpp7);/* mov ebx, 0x101a063f */
            ii(0x1009_8d10, 5);  mov(edx, StringDefinitions.StateEqualWaitingForMaterials);/* mov edx, 0x101a064c */
            ii(0x1009_8d15, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_8d17, 5);  call(Definitions.sys_assert, 0xc_d076);/* call 0x10165d92 */
            ii(0x1009_8d1c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1009_8d1f:
            ii(0x1009_8d1f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1009_8d21, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x1009_8d26, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_8d28, 2);  if(jnz(0x1009_8d3f, 0x15)) goto l_0x1009_8d3f;/* jnz 0x10098d3f */
            ii(0x1009_8d2a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8d2d, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_8d30, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8d33, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8d35, 6);  mov(dl, memb[ds, 0x101c_37c8]);       /* mov dl, [0x101c37c8] */
            ii(0x1009_8d3b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_8d3d, 2);  if(jnz(0x1009_8d41, 2)) goto l_0x1009_8d41;/* jnz 0x10098d41 */
        l_0x1009_8d3f:
            ii(0x1009_8d3f, 2);  jmp(0x1009_8d46, 5); goto l_0x1009_8d46;/* jmp 0x10098d46 */
        l_0x1009_8d41:
            ii(0x1009_8d41, 5);  jmp(0x1009_9107, 0x3c1); goto l_0x1009_9107;/* jmp 0x10099107 */
        l_0x1009_8d46:
            ii(0x1009_8d46, 3);  lea(ebx, memd[ss, ebp - 36]);         /* lea ebx, [ebp-0x24] */
            ii(0x1009_8d49, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1009_8d4c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8d4f, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_8d52, 5);  call(0x1007_6574, -0x2_27e3);         /* call 0x10076574 */
            ii(0x1009_8d57, 5);  call(0x1007_6204, -0x2_2b58);         /* call 0x10076204 */
            ii(0x1009_8d5c, 5);  call(0x1014_3616, 0xa_a8b5);          /* call 0x10143616 */
            ii(0x1009_8d61, 4);  movsx(eax, memw[ss, ebp - 22]);       /* movsx eax, word [ebp-0x16] */
            ii(0x1009_8d65, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1009_8d68, 6);  if(jl(0x1009_9107, 0x399)) goto l_0x1009_9107;/* jl 0x10099107 */
            ii(0x1009_8d6e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8d71, 5);  cmp(memw[ds, eax + 19], 0x3d);        /* cmp word [eax+0x13], 0x3d */
            ii(0x1009_8d76, 2);  if(jz(0x1009_8d82, 0xa)) goto l_0x1009_8d82;/* jz 0x10098d82 */
            ii(0x1009_8d78, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8d7b, 5);  cmp(memw[ds, eax + 19], 0x31);        /* cmp word [eax+0x13], 0x31 */
            ii(0x1009_8d80, 2);  if(jnz(0x1009_8db7, 0x35)) goto l_0x1009_8db7;/* jnz 0x10098db7 */
        l_0x1009_8d82:
            ii(0x1009_8d82, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8d85, 3);  mov(edx, memd[ds, eax + 17]);         /* mov edx, [eax+0x11] */
            ii(0x1009_8d88, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_8d8b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8d8e, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_8d91, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8d94, 5);  call(0x100b_71dc, 0x1_e443);          /* call 0x100b71dc */
            ii(0x1009_8d99, 1);  cwde();                               /* cwde */
            ii(0x1009_8d9a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_8d9c, 2);  if(jle(0x1009_8db0, 0x12)) goto l_0x1009_8db0;/* jle 0x10098db0 */
            ii(0x1009_8d9e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8da1, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_8da4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8da7, 5);  call(0x100a_5c69, 0xcebd);            /* call 0x100a5c69 */
            ii(0x1009_8dac, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_8dae, 2);  if(jnz(0x1009_8db2, 2)) goto l_0x1009_8db2;/* jnz 0x10098db2 */
        l_0x1009_8db0:
            ii(0x1009_8db0, 2);  jmp(0x1009_8db7, 5); goto l_0x1009_8db7;/* jmp 0x10098db7 */
        l_0x1009_8db2:
            ii(0x1009_8db2, 5);  jmp(0x1009_9107, 0x350); goto l_0x1009_9107;/* jmp 0x10099107 */
        l_0x1009_8db7:
            ii(0x1009_8db7, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_8dbb, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1009_8dbe, 6);  if(jge(0x1009_9055, 0x291)) goto l_0x1009_9055;/* jge 0x10099055 */
            ii(0x1009_8dc4, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x1009_8dcb, 7);  mov(memd[ss, ebp - 44], 0);           /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1009_8dd2, 7);  mov(memd[ss, ebp - 48], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x1009_8dd9, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1009_8dde, 5);  call(0x1007_6338, -0x2_2aab);         /* call 0x10076338 */
            ii(0x1009_8de3, 3);  lea(ebx, memd[ss, ebp - 52]);         /* lea ebx, [ebp-0x34] */
            ii(0x1009_8de6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_8de8, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1009_8dea, 5);  call(0x1007_64b8, -0x2_2937);         /* call 0x100764b8 */
            ii(0x1009_8def, 2);  jmp(0x1009_8df9, 8); goto l_0x1009_8df9;/* jmp 0x10098df9 */
        l_0x1009_8df1:
            ii(0x1009_8df1, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8df4, 5);  call(0x1007_6bf8, -0x2_2201);         /* call 0x10076bf8 */
        l_0x1009_8df9:
            ii(0x1009_8df9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8dfb, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8dfe, 5);  call(0x1013_ad71, 0xa_1f6e);          /* call 0x1013ad71 */
            ii(0x1009_8e03, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_8e05, 6);  if(jz(0x1009_8ebc, 0xb1)) goto l_0x1009_8ebc;/* jz 0x10098ebc */
            ii(0x1009_8e0b, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8e0e, 5);  call(0x1007_63a0, -0x2_2a73);         /* call 0x100763a0 */
            ii(0x1009_8e13, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8e15, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1009_8e18, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8e1b, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_8e1e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8e21, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_8e23, 6);  if(jnz(0x1009_8eb7, 0x8e)) goto l_0x1009_8eb7;/* jnz 0x10098eb7 */
            ii(0x1009_8e29, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8e2c, 5);  call(0x1007_63a0, -0x2_2a91);         /* call 0x100763a0 */
            ii(0x1009_8e31, 5);  cmp(memw[ds, eax + 8], 0x28);         /* cmp word [eax+0x8], 0x28 */
            ii(0x1009_8e36, 2);  if(jnz(0x1009_8e43, 0xb)) goto l_0x1009_8e43;/* jnz 0x10098e43 */
            ii(0x1009_8e38, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_8e3b, 3);  inc(memd[ss, ebp - 40]);              /* inc dword [ebp-0x28] */
            ii(0x1009_8e3e, 5);  jmp(0x1009_8eb7, 0x74); goto l_0x1009_8eb7;/* jmp 0x10098eb7 */
        l_0x1009_8e43:
            ii(0x1009_8e43, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8e46, 5);  call(0x1007_63a0, -0x2_2aab);         /* call 0x100763a0 */
            ii(0x1009_8e4b, 5);  cmp(memw[ds, eax + 8], 0x1e);         /* cmp word [eax+0x8], 0x1e */
            ii(0x1009_8e50, 2);  if(jz(0x1009_8e61, 0xf)) goto l_0x1009_8e61;/* jz 0x10098e61 */
            ii(0x1009_8e52, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8e55, 5);  call(0x1007_63a0, -0x2_2aba);         /* call 0x100763a0 */
            ii(0x1009_8e5a, 5);  cmp(memw[ds, eax + 8], 0x1e);         /* cmp word [eax+0x8], 0x1e */
            ii(0x1009_8e5f, 2);  if(jnz(0x1009_8e69, 8)) goto l_0x1009_8e69;/* jnz 0x10098e69 */
        l_0x1009_8e61:
            ii(0x1009_8e61, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1009_8e64, 3);  inc(memd[ss, ebp - 44]);              /* inc dword [ebp-0x2c] */
            ii(0x1009_8e67, 2);  jmp(0x1009_8eb7, 0x4e); goto l_0x1009_8eb7;/* jmp 0x10098eb7 */
        l_0x1009_8e69:
            ii(0x1009_8e69, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8e6c, 5);  call(0x1007_63a0, -0x2_2ad1);         /* call 0x100763a0 */
            ii(0x1009_8e71, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1009_8e75, 2);  if(jnz(0x1009_8e85, 0xe)) goto l_0x1009_8e85;/* jnz 0x10098e85 */
            ii(0x1009_8e77, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8e7a, 5);  call(0x1007_63a0, -0x2_2adf);         /* call 0x100763a0 */
            ii(0x1009_8e7f, 4);  cmp(memb[ds, eax + 62], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1009_8e83, 2);  if(jnz(0x1009_8e87, 2)) goto l_0x1009_8e87;/* jnz 0x10098e87 */
        l_0x1009_8e85:
            ii(0x1009_8e85, 2);  jmp(0x1009_8e9f, 0x18); goto l_0x1009_8e9f;/* jmp 0x10098e9f */
        l_0x1009_8e87:
            ii(0x1009_8e87, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8e8a, 5);  call(0x1007_63a0, -0x2_2aef);         /* call 0x100763a0 */
            ii(0x1009_8e8f, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1009_8e92, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8e95, 5);  call(0x1007_1f2e, -0x2_6f6c);         /* call 0x10071f2e */
            ii(0x1009_8e9a, 1);  cwde();                               /* cwde */
            ii(0x1009_8e9b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_8e9d, 2);  if(jg(0x1009_8ea1, 2)) goto l_0x1009_8ea1;/* jg 0x10098ea1 */
        l_0x1009_8e9f:
            ii(0x1009_8e9f, 2);  jmp(0x1009_8eb7, 0x16); goto l_0x1009_8eb7;/* jmp 0x10098eb7 */
        l_0x1009_8ea1:
            ii(0x1009_8ea1, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8ea4, 5);  call(0x1007_63a0, -0x2_2b09);         /* call 0x100763a0 */
            ii(0x1009_8ea9, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1009_8eac, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8eaf, 5);  call(0x1007_1f2e, -0x2_6f86);         /* call 0x10071f2e */
            ii(0x1009_8eb4, 3);  add(memd[ss, ebp - 48], eax);         /* add [ebp-0x30], eax */
        l_0x1009_8eb7:
            ii(0x1009_8eb7, 5);  jmp(0x1009_8df1, -0xcb); goto l_0x1009_8df1;/* jmp 0x10098df1 */
        l_0x1009_8ebc:
            ii(0x1009_8ebc, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1009_8ec0, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x1009_8ec5, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1009_8ec7, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1009_8eca, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1009_8ecc, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x1009_8ed1, 2);  sub(ebx, edx);                        /* sub ebx, edx */
            ii(0x1009_8ed3, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1009_8ed5, 3);  mov(memd[ss, ebp - 56], edx);         /* mov [ebp-0x38], edx */
            ii(0x1009_8ed8, 4);  movsx(edx, memw[ss, ebp - 56]);       /* movsx edx, word [ebp-0x38] */
            ii(0x1009_8edc, 3);  cmp(edx, 3);                          /* cmp edx, 0x3 */
            ii(0x1009_8edf, 2);  if(jle(0x1009_8ee8, 7)) goto l_0x1009_8ee8;/* jle 0x10098ee8 */
            ii(0x1009_8ee1, 7);  mov(memd[ss, ebp - 56], 0);           /* mov dword [ebp-0x38], 0x0 */
        l_0x1009_8ee8:
            ii(0x1009_8ee8, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_8eeb, 3);  sub(memd[ss, ebp - 56], eax);         /* sub [ebp-0x38], eax */
            ii(0x1009_8eee, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1009_8ef1, 4);  cmp(ax, memw[ss, ebp - 56]);          /* cmp ax, [ebp-0x38] */
            ii(0x1009_8ef5, 6);  if(jl(0x1009_904b, 0x150)) goto l_0x1009_904b;/* jl 0x1009904b */
            ii(0x1009_8efb, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1009_8eff, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_8f01, 2);  if(jnz(0x1009_8f12, 0xf)) goto l_0x1009_8f12;/* jnz 0x10098f12 */
            ii(0x1009_8f03, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8f05, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f08, 5);  call(0x1007_5f6c, -0x2_2fa1);         /* call 0x10075f6c */
            ii(0x1009_8f0d, 5);  jmp(0x1009_9107, 0x1f5); goto l_0x1009_9107;/* jmp 0x10099107 */
        l_0x1009_8f12:
            ii(0x1009_8f12, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1009_8f15, 3);  sub(eax, memd[ss, ebp - 56]);         /* sub eax, [ebp-0x38] */
            ii(0x1009_8f18, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_8f19, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1009_8f1c, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1009_8f21, 5);  call(0x1007_6338, -0x2_2bee);         /* call 0x10076338 */
            ii(0x1009_8f26, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_8f28, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f2b, 5);  call(0x1007_643c, -0x2_2af4);         /* call 0x1007643c */
            ii(0x1009_8f30, 2);  jmp(0x1009_8f3a, 8); goto l_0x1009_8f3a;/* jmp 0x10098f3a */
        l_0x1009_8f32:
            ii(0x1009_8f32, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f35, 5);  call(0x1007_6bf8, -0x2_2342);         /* call 0x10076bf8 */
        l_0x1009_8f3a:
            ii(0x1009_8f3a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8f3c, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f3f, 5);  call(0x1013_ad71, 0xa_1e2d);          /* call 0x1013ad71 */
            ii(0x1009_8f44, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_8f46, 2);  if(jz(0x1009_8f50, 8)) goto l_0x1009_8f50;/* jz 0x10098f50 */
            ii(0x1009_8f48, 4);  movsx(eax, memw[ss, ebp - 60]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1009_8f4c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_8f4e, 2);  if(jg(0x1009_8f52, 2)) goto l_0x1009_8f52;/* jg 0x10098f52 */
        l_0x1009_8f50:
            ii(0x1009_8f50, 2);  jmp(0x1009_8fa7, 0x55); goto l_0x1009_8fa7;/* jmp 0x10098fa7 */
        l_0x1009_8f52:
            ii(0x1009_8f52, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f55, 5);  call(0x1007_63a0, -0x2_2bba);         /* call 0x100763a0 */
            ii(0x1009_8f5a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8f5c, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1009_8f5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8f62, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_8f65, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8f68, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_8f6a, 2);  if(jnz(0x1009_8f7b, 0xf)) goto l_0x1009_8f7b;/* jnz 0x10098f7b */
            ii(0x1009_8f6c, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f6f, 5);  call(0x1007_63a0, -0x2_2bd4);         /* call 0x100763a0 */
            ii(0x1009_8f74, 5);  cmp(memw[ds, eax + 8], 0x1e);         /* cmp word [eax+0x8], 0x1e */
            ii(0x1009_8f79, 2);  if(jz(0x1009_8f7d, 2)) goto l_0x1009_8f7d;/* jz 0x10098f7d */
        l_0x1009_8f7b:
            ii(0x1009_8f7b, 2);  jmp(0x1009_8fa5, 0x28); goto l_0x1009_8fa5;/* jmp 0x10098fa5 */
        l_0x1009_8f7d:
            ii(0x1009_8f7d, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f80, 5);  call(0x1007_63a0, -0x2_2be5);         /* call 0x100763a0 */
            ii(0x1009_8f85, 4);  cmp(memb[ds, eax + 61], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1009_8f89, 2);  if(jnz(0x1009_8f9f, 0x14)) goto l_0x1009_8f9f;/* jnz 0x10098f9f */
            ii(0x1009_8f8b, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_8f8d, 5);  mov(edx, 8);                          /* mov edx, 0x8 */
            ii(0x1009_8f92, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8f95, 5);  call(0x1007_63d4, -0x2_2bc6);         /* call 0x100763d4 */
            ii(0x1009_8f9a, 5);  call(0x1016_3053, 0xc_a0b4);          /* call 0x10163053 */
        l_0x1009_8f9f:
            ii(0x1009_8f9f, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1009_8fa2, 3);  dec(memd[ss, ebp - 60]);              /* dec dword [ebp-0x3c] */
        l_0x1009_8fa5:
            ii(0x1009_8fa5, 2);  jmp(0x1009_8f32, -0x75); goto l_0x1009_8f32;/* jmp 0x10098f32 */
        l_0x1009_8fa7:
            ii(0x1009_8fa7, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1009_8fac, 5);  call(0x1007_6338, -0x2_2c79);         /* call 0x10076338 */
            ii(0x1009_8fb1, 3);  lea(ebx, memd[ss, ebp - 52]);         /* lea ebx, [ebp-0x34] */
            ii(0x1009_8fb4, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_8fb6, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1009_8fb8, 5);  call(0x1007_643c, -0x2_2b81);         /* call 0x1007643c */
            ii(0x1009_8fbd, 2);  jmp(0x1009_8fc7, 8); goto l_0x1009_8fc7;/* jmp 0x10098fc7 */
        l_0x1009_8fbf:
            ii(0x1009_8fbf, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8fc2, 5);  call(0x1007_6bf8, -0x2_23cf);         /* call 0x10076bf8 */
        l_0x1009_8fc7:
            ii(0x1009_8fc7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8fc9, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8fcc, 5);  call(0x1013_ad71, 0xa_1da0);          /* call 0x1013ad71 */
            ii(0x1009_8fd1, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_8fd3, 2);  if(jz(0x1009_8fdd, 8)) goto l_0x1009_8fdd;/* jz 0x10098fdd */
            ii(0x1009_8fd5, 4);  movsx(eax, memw[ss, ebp - 60]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1009_8fd9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_8fdb, 2);  if(jg(0x1009_8fdf, 2)) goto l_0x1009_8fdf;/* jg 0x10098fdf */
        l_0x1009_8fdd:
            ii(0x1009_8fdd, 2);  jmp(0x1009_9034, 0x55); goto l_0x1009_9034;/* jmp 0x10099034 */
        l_0x1009_8fdf:
            ii(0x1009_8fdf, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8fe2, 5);  call(0x1007_63a0, -0x2_2c47);         /* call 0x100763a0 */
            ii(0x1009_8fe7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8fe9, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1009_8fec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8fef, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_8ff2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_8ff5, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1009_8ff7, 2);  if(jnz(0x1009_9008, 0xf)) goto l_0x1009_9008;/* jnz 0x10099008 */
            ii(0x1009_8ff9, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_8ffc, 5);  call(0x1007_63a0, -0x2_2c61);         /* call 0x100763a0 */
            ii(0x1009_9001, 5);  cmp(memw[ds, eax + 8], 0);            /* cmp word [eax+0x8], 0x0 */
            ii(0x1009_9006, 2);  if(jz(0x1009_900a, 2)) goto l_0x1009_900a;/* jz 0x1009900a */
        l_0x1009_9008:
            ii(0x1009_9008, 2);  jmp(0x1009_9032, 0x28); goto l_0x1009_9032;/* jmp 0x10099032 */
        l_0x1009_900a:
            ii(0x1009_900a, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_900d, 5);  call(0x1007_63a0, -0x2_2c72);         /* call 0x100763a0 */
            ii(0x1009_9012, 4);  cmp(memb[ds, eax + 61], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1009_9016, 2);  if(jnz(0x1009_902c, 0x14)) goto l_0x1009_902c;/* jnz 0x1009902c */
            ii(0x1009_9018, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_901a, 5);  mov(edx, 8);                          /* mov edx, 0x8 */
            ii(0x1009_901f, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_9022, 5);  call(0x1007_63d4, -0x2_2c53);         /* call 0x100763d4 */
            ii(0x1009_9027, 5);  call(0x1016_3053, 0xc_a027);          /* call 0x10163053 */
        l_0x1009_902c:
            ii(0x1009_902c, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1009_902f, 3);  dec(memd[ss, ebp - 60]);              /* dec dword [ebp-0x3c] */
        l_0x1009_9032:
            ii(0x1009_9032, 2);  jmp(0x1009_8fbf, -0x75); goto l_0x1009_8fbf;/* jmp 0x10098fbf */
        l_0x1009_9034:
            ii(0x1009_9034, 4);  movsx(eax, memw[ss, ebp - 60]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1009_9038, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_903a, 2);  if(jle(0x1009_904b, 0xf)) goto l_0x1009_904b;/* jle 0x1009904b */
            ii(0x1009_903c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_903e, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_9041, 5);  call(0x1007_5f6c, -0x2_30da);         /* call 0x10075f6c */
            ii(0x1009_9046, 5);  jmp(0x1009_9107, 0xbc); goto l_0x1009_9107;/* jmp 0x10099107 */
        l_0x1009_904b:
            ii(0x1009_904b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_904d, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_9050, 5);  call(0x1007_5f6c, -0x2_30e9);         /* call 0x10075f6c */
        l_0x1009_9055:
            ii(0x1009_9055, 3);  lea(edx, memd[ss, ebp - 12]);         /* lea edx, [ebp-0xc] */
            ii(0x1009_9058, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_905b, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_905e, 5);  call(0x1007_6574, -0x2_2aef);         /* call 0x10076574 */
            ii(0x1009_9063, 5);  call(0x1015_0a5f, 0xb_79f7);          /* call 0x10150a5f */
            ii(0x1009_9068, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_906b, 4);  mov(memb[ds, eax + 29], 3);           /* mov byte [eax+0x1d], 0x3 */
            ii(0x1009_906f, 4);  movsx(eax, memw[ss, ebp - 22]);       /* movsx eax, word [ebp-0x16] */
            ii(0x1009_9073, 3);  cmp(eax, 0x64);                       /* cmp eax, 0x64 */
            ii(0x1009_9076, 2);  if(jle(0x1009_9087, 0xf)) goto l_0x1009_9087;/* jle 0x10099087 */
            ii(0x1009_9078, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1009_907d, 5);  call(0x1007_5fdc, -0x2_30a6);         /* call 0x10075fdc */
            ii(0x1009_9082, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_9085, 2);  if(jge(0x1009_9089, 2)) goto l_0x1009_9089;/* jge 0x10099089 */
        l_0x1009_9087:
            ii(0x1009_9087, 2);  jmp(0x1009_90a0, 0x17); goto l_0x1009_90a0;/* jmp 0x100990a0 */
        l_0x1009_9089:
            ii(0x1009_9089, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x1009_908e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9091, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_9094, 5);  call(0x1007_6574, -0x2_2b25);         /* call 0x10076574 */
            ii(0x1009_9099, 5);  call(0x1009_c970, 0x38d2);            /* call 0x1009c970 */
            ii(0x1009_909e, 2);  jmp(0x1009_90b5, 0x15); goto l_0x1009_90b5;/* jmp 0x100990b5 */
        l_0x1009_90a0:
            ii(0x1009_90a0, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_90a5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_90a8, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_90ab, 5);  call(0x1007_6574, -0x2_2b3c);         /* call 0x10076574 */
            ii(0x1009_90b0, 5);  call(0x1009_c970, 0x38bb);            /* call 0x1009c970 */
        l_0x1009_90b5:
            ii(0x1009_90b5, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_90b8, 5);  call(0x1009_caf8, 0x3a3b);            /* call 0x1009caf8 */
            ii(0x1009_90bd, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_90c0, 3);  add(edx, 0x13);                       /* add edx, 0x13 */
            ii(0x1009_90c3, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_90c6, 5);  call(0x1008_b2a8, -0xde23);           /* call 0x1008b2a8 */
            ii(0x1009_90cb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_90ce, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_90d1, 5);  call(0x1007_6574, -0x2_2b62);         /* call 0x10076574 */
            ii(0x1009_90d6, 6);  mov(memw[ds, eax + 65], 0);           /* mov word [eax+0x41], 0x0 */
            ii(0x1009_90dc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_90df, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_90e2, 5);  call(0x1007_6574, -0x2_2b73);         /* call 0x10076574 */
            ii(0x1009_90e7, 6);  mov(memw[ds, eax + 67], 0);           /* mov word [eax+0x43], 0x0 */
            ii(0x1009_90ed, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_90f0, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_90f3, 5);  call(0x1007_6574, -0x2_2b84);         /* call 0x10076574 */
            ii(0x1009_90f8, 5);  call(0x1015_2387, 0xb_928a);          /* call 0x10152387 */
            ii(0x1009_90fd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_90ff, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1009_9102, 5);  call(0x1008_8b04, -0x1_0603);         /* call 0x10088b04 */
        l_0x1009_9107:
            ii(0x1009_9107, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_9109, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_910a, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_910b, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_910c, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_910d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_910e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_910f, 1);  ret();                                /* ret */
        }
    }
}
