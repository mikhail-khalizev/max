using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_09dc-e8ab6720")]
        public void /* sys */ Method_1017_09dc()
        {
            ii(0x1017_09dc, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_09dd, 1);  push(esi);                            /* push esi */
            ii(0x1017_09de, 1);  push(edi);                            /* push edi */
            ii(0x1017_09df, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_09e0, 3);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1017_09e3, 2);  mov(ebp, eax);                        /* mov ebp, eax */
            ii(0x1017_09e5, 4);  mov(memd[ss, esp + 16], ebx);         /* mov [esp+0x10], ebx */
            ii(0x1017_09e9, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_09eb, 2);  test(ebp, ebp);                       /* test ebp, ebp */
            ii(0x1017_09ed, 6);  if(jz(0x1017_0bed, 0x1fa)) goto l_0x1017_0bed;/* jz 0x10170bed */
            ii(0x1017_09f3, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1017_09f5, 6);  if(jz(0x1017_0bf2, 0x1f7)) goto l_0x1017_0bf2;/* jz 0x10170bf2 */
            ii(0x1017_09fb, 10);  mov(memd[ds, 0x101b_e1c4], 1);       /* mov dword [0x101be1c4], 0x1 */
            ii(0x1017_0a05, 6);  call_abs(memd[ds, 0x101b_e1cc]);      /* call dword [0x101be1cc] */ /* Вызов '0x1017_11ac'. */
            ii(0x1017_0a0b, 3);  mov(memd[ss, ebp], eax);              /* mov [ebp], eax */
            ii(0x1017_0a0e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0a10, 6);  if(jz(0x1017_0bed, 0x1d7)) goto l_0x1017_0bed;/* jz 0x10170bed */
            ii(0x1017_0a16, 5);  mov(edx, StringDefinitions.Rb2);      /* mov edx, 0x101b2ed8 */
            ii(0x1017_0a1b, 5);  call(Definitions.sys_fopen, 0x195a);  /* call 0x1017237a */
            ii(0x1017_0a20, 3);  mov(memd[ss, ebp + 4], eax);          /* mov [ebp+0x4], eax */
            ii(0x1017_0a23, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0a25, 6);  if(jz(0x1017_0bdd, 0x1b2)) goto l_0x1017_0bdd;/* jz 0x10170bdd */
            ii(0x1017_0a2b, 5);  mov(ebx, 0x24);                       /* mov ebx, 0x24 */
            ii(0x1017_0a30, 3);  lea(esi, memd[ss, ebp + 20]);         /* lea esi, [ebp+0x14] */
            ii(0x1017_0a33, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1017_0a35, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_0a37, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1017_0a39, 5);  call(/* sys */ 0x1018_b5c8, 0x1_ab8a);/* call 0x1018b5c8 */
            ii(0x1017_0a3e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0a40, 6);  if(jnz(0x1017_0bd5, 0x18f)) goto l_0x1017_0bd5;/* jnz 0x10170bd5 */
            ii(0x1017_0a46, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1017_0a48, 3);  mov(eax, memd[ss, ebp + 4]);          /* mov eax, [ebp+0x4] */
            ii(0x1017_0a4b, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1017_0a4d, 5);  call(/* sys */ 0x1018_bb60, 0x1_b10e);/* call 0x1018bb60 */
            ii(0x1017_0a52, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0a54, 6);  if(jnz(0x1017_0bd5, 0x17b)) goto l_0x1017_0bd5;/* jnz 0x10170bd5 */
            ii(0x1017_0a5a, 3);  mov(edx, memd[ss, ebp + 24]);         /* mov edx, [ebp+0x18] */
            ii(0x1017_0a5d, 7);  lea(eax, memd[ds, edx * 8]);          /* lea eax, [edx*8] */
            ii(0x1017_0a64, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1017_0a66, 5);  mov(esi, 1);                          /* mov esi, 0x1 */
            ii(0x1017_0a6b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1017_0a6e, 6);  mov(memd[ds, 0x101b_e1c4], esi);      /* mov [0x101be1c4], esi */
            ii(0x1017_0a74, 6);  call_abs(memd[ds, 0x101b_e1c8]);      /* call dword [0x101be1c8] */ /* Вызов '0x1017_11a4'. */
            ii(0x1017_0a7a, 3);  mov(memd[ss, ebp + 56], eax);         /* mov [ebp+0x38], eax */
            ii(0x1017_0a7d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0a7f, 6);  if(jz(0x1017_0bcd, 0x148)) goto l_0x1017_0bcd;/* jz 0x10170bcd */
            ii(0x1017_0a85, 5);  mov(eax, /* sys */ 0x1017_0374);      /* mov eax, 0x10170374 */
            ii(0x1017_0a8a, 5);  mov(edx, /* sys */ 0x1017_03bc);      /* mov edx, 0x101703bc */
            ii(0x1017_0a8f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1017_0a91, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
            ii(0x1017_0a94, 4);  mov(memd[ss, esp + 4], edx);          /* mov [esp+0x4], edx */
            ii(0x1017_0a98, 4);  mov(memd[ss, esp + 8], ebx);          /* mov [esp+0x8], ebx */
            ii(0x1017_0a9c, 4);  mov(memd[ss, esp + 12], ebx);         /* mov [esp+0xc], ebx */
            ii(0x1017_0aa0, 3);  mov(edi, memd[ss, ebp + 24]);         /* mov edi, [ebp+0x18] */
            ii(0x1017_0aa3, 2);  xor(esi, esi);                        /* xor esi, esi */
            ii(0x1017_0aa5, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1017_0aa7, 6);  if(jle(0x1017_0b37, 0x8a)) goto l_0x1017_0b37;/* jle 0x10170b37 */
            ii(0x1017_0aad, 5);  mov(ebx, 0xffff_ffff);                /* mov ebx, 0xffffffff */
            ii(0x1017_0ab2, 2);  xor(edi, edi);                        /* xor edi, edi */
            ii(0x1017_0ab4, 4);  mov(memd[ss, esp + 20], ebx);         /* mov [esp+0x14], ebx */
        l_0x1017_0ab8:
            ii(0x1017_0ab8, 2);  mov(ecx, esp);                        /* mov ecx, esp */
            ii(0x1017_0aba, 5);  mov(ebx, 0x10);                       /* mov ebx, 0x10 */
            ii(0x1017_0abf, 3);  mov(eax, memd[ss, ebp + 56]);         /* mov eax, [ebp+0x38] */
            ii(0x1017_0ac2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_0ac4, 2);  add(eax, edi);                        /* add eax, edi */
            ii(0x1017_0ac6, 5);  call(/* sys */ 0x1018_b5c8, 0x1_aafd);/* call 0x1018b5c8 */
            ii(0x1017_0acb, 4);  mov(edx, memd[ss, esp + 20]);         /* mov edx, [esp+0x14] */
            ii(0x1017_0acf, 3);  imul(ecx, edx, 0x24);                 /* imul ecx, edx, 0x24 */
            ii(0x1017_0ad2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0ad4, 2);  if(jnz(0x1017_0b07, 0x31)) goto l_0x1017_0b07;/* jnz 0x10170b07 */
            ii(0x1017_0ad6, 3);  mov(edx, memd[ss, ebp + 56]);         /* mov edx, [ebp+0x38] */
            ii(0x1017_0ad9, 3);  mov(eax, memd[ss, ebp + 4]);          /* mov eax, [ebp+0x4] */
            ii(0x1017_0adc, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1017_0ade, 2);  add(edx, edi);                        /* add edx, edi */
            ii(0x1017_0ae0, 5);  call(/* sys */ 0x1018_bb60, 0x1_b07b);/* call 0x1018bb60 */
            ii(0x1017_0ae5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0ae7, 2);  if(jz(0x1017_0b23, 0x3a)) goto l_0x1017_0b23;/* jz 0x10170b23 */
            ii(0x1017_0ae9, 4);  mov(esi, memd[ss, esp + 20]);         /* mov esi, [esp+0x14] */
            ii(0x1017_0aed, 2);  test(esi, esi);                       /* test esi, esi */
            ii(0x1017_0aef, 2);  if(jl(0x1017_0b37, 0x46)) goto l_0x1017_0b37;/* jl 0x10170b37 */
            ii(0x1017_0af1, 2);  mov(edi, ecx);                        /* mov edi, ecx */
        l_0x1017_0af3:
            ii(0x1017_0af3, 3);  mov(eax, memd[ss, ebp + 56]);         /* mov eax, [ebp+0x38] */
            ii(0x1017_0af6, 1);  dec(esi);                             /* dec esi */
            ii(0x1017_0af7, 2);  add(eax, edi);                        /* add eax, edi */
            ii(0x1017_0af9, 3);  sub(edi, 0x24);                       /* sub edi, 0x24 */
            ii(0x1017_0afc, 5);  call(/* sys */ 0x1018_b664, 0x1_ab63);/* call 0x1018b664 */
            ii(0x1017_0b01, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1017_0b03, 2);  if(jl(0x1017_0b37, 0x32)) goto l_0x1017_0b37;/* jl 0x10170b37 */
            ii(0x1017_0b05, 2);  jmp(0x1017_0af3, -0x14); goto l_0x1017_0af3;/* jmp 0x10170af3 */
        l_0x1017_0b07:
            ii(0x1017_0b07, 2);  mov(esi, edx);                        /* mov esi, edx */
            ii(0x1017_0b09, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1017_0b0b, 2);  if(jl(0x1017_0b37, 0x2a)) goto l_0x1017_0b37;/* jl 0x10170b37 */
            ii(0x1017_0b0d, 2);  mov(edi, ecx);                        /* mov edi, ecx */
        l_0x1017_0b0f:
            ii(0x1017_0b0f, 3);  mov(eax, memd[ss, ebp + 56]);         /* mov eax, [ebp+0x38] */
            ii(0x1017_0b12, 1);  dec(esi);                             /* dec esi */
            ii(0x1017_0b13, 2);  add(eax, edi);                        /* add eax, edi */
            ii(0x1017_0b15, 3);  sub(edi, 0x24);                       /* sub edi, 0x24 */
            ii(0x1017_0b18, 5);  call(/* sys */ 0x1018_b664, 0x1_ab47);/* call 0x1018b664 */
            ii(0x1017_0b1d, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1017_0b1f, 2);  if(jl(0x1017_0b37, 0x16)) goto l_0x1017_0b37;/* jl 0x10170b37 */
            ii(0x1017_0b21, 2);  jmp(0x1017_0b0f, -0x14); goto l_0x1017_0b0f;/* jmp 0x10170b0f */
        l_0x1017_0b23:
            ii(0x1017_0b23, 4);  mov(eax, memd[ss, esp + 20]);         /* mov eax, [esp+0x14] */
            ii(0x1017_0b27, 3);  add(edi, 0x24);                       /* add edi, 0x24 */
            ii(0x1017_0b2a, 1);  inc(esi);                             /* inc esi */
            ii(0x1017_0b2b, 1);  inc(eax);                             /* inc eax */
            ii(0x1017_0b2c, 3);  mov(edx, memd[ss, ebp + 24]);         /* mov edx, [ebp+0x18] */
            ii(0x1017_0b2f, 4);  mov(memd[ss, esp + 20], eax);         /* mov [esp+0x14], eax */
            ii(0x1017_0b33, 2);  cmp(esi, edx);                        /* cmp esi, edx */
            ii(0x1017_0b35, 2);  if(jl(0x1017_0ab8, -0x7f)) goto l_0x1017_0ab8;/* jl 0x10170ab8 */
        l_0x1017_0b37:
            ii(0x1017_0b37, 3);  cmp(esi, memd[ss, ebp + 24]);         /* cmp esi, [ebp+0x18] */
            ii(0x1017_0b3a, 6);  if(jnz(0x1017_0bc4, 0x84)) goto l_0x1017_0bc4;/* jnz 0x10170bc4 */
            ii(0x1017_0b40, 4);  mov(edx, memd[ss, esp + 16]);         /* mov edx, [esp+0x10] */
            ii(0x1017_0b44, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1017_0b46, 2);  if(jz(0x1017_0b62, 0x1a)) goto l_0x1017_0b62;/* jz 0x10170b62 */
            ii(0x1017_0b48, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1017_0b4a, 2);  sub(ecx, ecx);                        /* sub ecx, ecx */
            ii(0x1017_0b4c, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_0b4d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_0b4f, 2);  repne(() => scasb());                 /* repne scasb */
            ii(0x1017_0b51, 2);  not(ecx);                             /* not ecx */
            ii(0x1017_0b53, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_0b54, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1017_0b56, 2);  if(jz(0x1017_0b62, 0xa)) goto l_0x1017_0b62;/* jz 0x10170b62 */
            ii(0x1017_0b58, 2);  mov(esi, edx);                        /* mov esi, edx */
            ii(0x1017_0b5a, 3);  cmp(memb[ds, edx], 0x5c);             /* cmp byte [edx], 0x5c */
            ii(0x1017_0b5d, 2);  if(jnz(0x1017_0b67, 8)) goto l_0x1017_0b67;/* jnz 0x10170b67 */
            ii(0x1017_0b5f, 1);  inc(esi);                             /* inc esi */
            ii(0x1017_0b60, 2);  jmp(0x1017_0b67, 5); goto l_0x1017_0b67;/* jmp 0x10170b67 */
        l_0x1017_0b62:
            ii(0x1017_0b62, 5);  mov(esi, StringDefinitions.Control11);/* mov esi, 0x101b2efc */
        l_0x1017_0b67:
            ii(0x1017_0b67, 2);  mov(edi, esi);                        /* mov edi, esi */
            ii(0x1017_0b69, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1017_0b6e, 2);  sub(ecx, ecx);                        /* sub ecx, ecx */
            ii(0x1017_0b70, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_0b71, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_0b73, 2);  repne(() => scasb());                 /* repne scasb */
            ii(0x1017_0b75, 2);  not(ecx);                             /* not ecx */
            ii(0x1017_0b77, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1017_0b78, 3);  lea(eax, memd[ds, ecx + 2]);          /* lea eax, [ecx+0x2] */
            ii(0x1017_0b7b, 6);  mov(memd[ds, 0x101b_e1c4], ebx);      /* mov [0x101be1c4], ebx */
            ii(0x1017_0b81, 6);  call_abs(memd[ds, 0x101b_e1c8]);      /* call dword [0x101be1c8] */ /* Вызов '0x1017_11a4'. */
            ii(0x1017_0b87, 3);  mov(memd[ss, ebp + 8], eax);          /* mov [ebp+0x8], eax */
            ii(0x1017_0b8a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0b8c, 2);  if(jz(0x1017_0bc4, 0x36)) goto l_0x1017_0bc4;/* jz 0x10170bc4 */
            ii(0x1017_0b8e, 2);  mov(edi, eax);                        /* mov edi, eax */
            ii(0x1017_0b90, 1);  push(edi);                            /* push edi */
        l_0x1017_0b91:
            ii(0x1017_0b91, 2);  mov(al, memb[ds, esi]);               /* mov al, [esi] */
            ii(0x1017_0b93, 2);  mov(memb[ds, edi], al);               /* mov [edi], al */
            ii(0x1017_0b95, 2);  cmp(al, 0);                           /* cmp al, 0x0 */
            ii(0x1017_0b97, 2);  if(jz(0x1017_0ba9, 0x10)) goto l_0x1017_0ba9;/* jz 0x10170ba9 */
            ii(0x1017_0b99, 3);  mov(al, memb[ds, esi + 1]);           /* mov al, [esi+0x1] */
            ii(0x1017_0b9c, 3);  add(esi, 2);                          /* add esi, 0x2 */
            ii(0x1017_0b9f, 3);  mov(memb[ds, edi + 1], al);           /* mov [edi+0x1], al */
            ii(0x1017_0ba2, 3);  add(edi, 2);                          /* add edi, 0x2 */
            ii(0x1017_0ba5, 2);  cmp(al, 0);                           /* cmp al, 0x0 */
            ii(0x1017_0ba7, 2);  if(jnz(0x1017_0b91, -0x18)) goto l_0x1017_0b91;/* jnz 0x10170b91 */
        l_0x1017_0ba9:
            ii(0x1017_0ba9, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_0baa, 3);  mov(eax, memd[ss, ebp + 8]);          /* mov eax, [ebp+0x8] */
            ii(0x1017_0bad, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x1017_0baf, 4);  cmp(memb[ds, eax - 1], 0x5c);         /* cmp byte [eax-0x1], 0x5c */
            ii(0x1017_0bb3, 2);  if(jz(0x1017_0bc0, 0xb)) goto l_0x1017_0bc0;/* jz 0x10170bc0 */
            ii(0x1017_0bb5, 3);  mov(memb[ds, eax], 0x5c);             /* mov byte [eax], 0x5c */
            ii(0x1017_0bb8, 3);  mov(eax, memd[ss, ebp + 8]);          /* mov eax, [ebp+0x8] */
            ii(0x1017_0bbb, 5);  mov(memb[ds, ecx + eax + 1], 0);      /* mov byte [ecx+eax+0x1], 0x0 */
        l_0x1017_0bc0:
            ii(0x1017_0bc0, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_0bc2, 2);  jmp(0x1017_0bf2, 0x2e); goto l_0x1017_0bf2;/* jmp 0x10170bf2 */
        l_0x1017_0bc4:
            ii(0x1017_0bc4, 3);  mov(eax, memd[ss, ebp + 56]);         /* mov eax, [ebp+0x38] */
            ii(0x1017_0bc7, 6);  call_abs(memd[ds, 0x101b_e1d0]);      /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
        l_0x1017_0bcd:
            ii(0x1017_0bcd, 3);  lea(eax, memd[ss, ebp + 20]);         /* lea eax, [ebp+0x14] */
            ii(0x1017_0bd0, 5);  call(/* sys */ 0x1018_b664, 0x1_aa8f);/* call 0x1018b664 */
        l_0x1017_0bd5:
            ii(0x1017_0bd5, 3);  mov(eax, memd[ss, ebp + 4]);          /* mov eax, [ebp+0x4] */
            ii(0x1017_0bd8, 5);  call(Definitions.sys_fclose, 0x148c); /* call 0x10172069 */
        l_0x1017_0bdd:
            ii(0x1017_0bdd, 3);  mov(eax, memd[ss, ebp]);              /* mov eax, [ebp] */
            ii(0x1017_0be0, 6);  call_abs(memd[ds, 0x101b_e1d0]);      /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
            ii(0x1017_0be6, 7);  mov(memd[ss, ebp], 0);                /* mov dword [ebp], 0x0 */
        l_0x1017_0bed:
            ii(0x1017_0bed, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
        l_0x1017_0bf2:
            ii(0x1017_0bf2, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x1017_0bf5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_0bf6, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_0bf7, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_0bf8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_0bf9, 1);  ret();                                /* ret */
        }
    }
}
