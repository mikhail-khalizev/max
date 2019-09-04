using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ca0a-34fa836c")]
        public void Method_1011_ca0a()
        {
            ii(0x1011_ca0a, 5);  push(0x50);                           /* push 0x50 */
            ii(0x1011_ca0f, 5);  call(Definitions.sys_check_available_stack_size, 0x4_933e);/* call 0x10165d52 */
            ii(0x1011_ca14, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_ca15, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_ca16, 1);  push(esi);                            /* push esi */
            ii(0x1011_ca17, 1);  push(edi);                            /* push edi */
            ii(0x1011_ca18, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_ca19, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_ca1b, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x1011_ca21, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_ca24, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_ca27, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1011_ca2a, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_5f3f);/* call 0x10076af0 */
            ii(0x1011_ca2f, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1011_ca32, 5);  call(Definitions.my_ctor_0x101b_4184, -0xa_5f47);/* call 0x10076af0 */
            ii(0x1011_ca37, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ca3a, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1011_ca3d, 5);  call(Definitions.my_3_get_count, -0x9_15c2);/* call 0x1008b480 */
            ii(0x1011_ca42, 1);  cwde();                               /* cwde */
            ii(0x1011_ca43, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_ca45, 2);  if(jnz(0x1011_ca50, 9)) goto l_0x1011_ca50;/* jnz 0x1011ca50 */
            ii(0x1011_ca47, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1011_ca4b, 5);  jmp(0x1011_cbf9, 0x1a9); goto l_0x1011_cbf9;/* jmp 0x1011cbf9 */
        l_0x1011_ca50:
            ii(0x1011_ca50, 6);  inc(memd[ds, 0x101c_52e8]);           /* inc dword [0x101c52e8] */
            ii(0x1011_ca56, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ca59, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1011_ca5c, 5);  call(Definitions.my_3_get_count, -0x9_15e1);/* call 0x1008b480 */
            ii(0x1011_ca61, 1);  dec(eax);                             /* dec eax */
            ii(0x1011_ca62, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_ca65, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ca68, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1011_ca6b, 5);  call(0x1012_0548, 0x3ad8);            /* call 0x10120548 */
            ii(0x1011_ca70, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_ca72, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1011_ca75, 5);  call(0x1008_8b44, -0x9_3f36);         /* call 0x10088b44 */
            ii(0x1011_ca7a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ca7d, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1011_ca80, 5);  call(Definitions.my_3_get_count, -0x9_1605);/* call 0x1008b480 */
            ii(0x1011_ca85, 1);  dec(eax);                             /* dec eax */
            ii(0x1011_ca86, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_ca89, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ca8c, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1011_ca8f, 5);  call(0x100c_db14, -0x4_ef80);         /* call 0x100cdb14 */
            ii(0x1011_ca94, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_ca98, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ca9b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_ca9d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_caa0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_caa2, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_caa4, 4);  movsx(edx, memw[ss, ebp - 34]);       /* movsx edx, word [ebp-0x22] */
            ii(0x1011_caa8, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1011_caaa, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_caac, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_caae, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1011_cab1, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_cab4, 4);  movsx(ecx, memw[ss, ebp - 20]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x1011_cab8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_cabb, 3);  add(edx, 0x1e);                       /* add edx, 0x1e */
            ii(0x1011_cabe, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1011_cac1, 5);  call(0x1007_5e64, -0xa_6c62);         /* call 0x10075e64 */
            ii(0x1011_cac6, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1011_cac8, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1011_cacb, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1011_cace, 5);  call(0x1007_5e64, -0xa_6c6f);         /* call 0x10075e64 */
            ii(0x1011_cad3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_cad5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cad8, 5);  call(0x1011_c936, -0x1a7);            /* call 0x1011c936 */
            ii(0x1011_cadd, 9);  mov(memw[ds, 0x101b_afd0], 1);        /* mov word [0x101bafd0], 0x1 */
            ii(0x1011_cae6, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_caed, 2);  jmp(0x1011_caf5, 6); goto l_0x1011_caf5;/* jmp 0x1011caf5 */
        l_0x1011_caef:
            ii(0x1011_caef, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_caf2, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1011_caf5:
            ii(0x1011_caf5, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_caf9, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1011_cafc, 6);  if(jge(0x1011_cbf5, 0xf3)) goto l_0x1011_cbf5;/* jge 0x1011cbf5 */
            ii(0x1011_cb02, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_cb06, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_cb09, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_cb0c, 7);  add(ax, memw[ds, edx + 0x101c_5348]); /* add ax, [edx+0x101c5348] */
            ii(0x1011_cb13, 4);  mov(memw[ss, ebp - 40], ax);          /* mov [ebp-0x28], ax */
            ii(0x1011_cb17, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_cb1b, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_cb1e, 3);  mov(eax, memd[ss, ebp - 34]);         /* mov eax, [ebp-0x22] */
            ii(0x1011_cb21, 7);  add(ax, memw[ds, edx + 0x101c_534a]); /* add ax, [edx+0x101c534a] */
            ii(0x1011_cb28, 4);  mov(memw[ss, ebp - 38], ax);          /* mov [ebp-0x26], ax */
            ii(0x1011_cb2c, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_cb30, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1011_cb32, 2);  if(jl(0x1011_cb40, 0xc)) goto l_0x1011_cb40;/* jl 0x1011cb40 */
            ii(0x1011_cb34, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_cb37, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1011_cb3e, 2);  if(jl(0x1011_cb42, 2)) goto l_0x1011_cb42;/* jl 0x1011cb42 */
        l_0x1011_cb40:
            ii(0x1011_cb40, 2);  jmp(0x1011_cb4a, 8); goto l_0x1011_cb4a;/* jmp 0x1011cb4a */
        l_0x1011_cb42:
            ii(0x1011_cb42, 4);  movsx(eax, memw[ss, ebp - 38]);       /* movsx eax, word [ebp-0x26] */
            ii(0x1011_cb46, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_cb48, 2);  if(jge(0x1011_cb4c, 2)) goto l_0x1011_cb4c;/* jge 0x1011cb4c */
        l_0x1011_cb4a:
            ii(0x1011_cb4a, 2);  jmp(0x1011_cb58, 0xc); goto l_0x1011_cb58;/* jmp 0x1011cb58 */
        l_0x1011_cb4c:
            ii(0x1011_cb4c, 3);  mov(eax, memd[ss, ebp - 38]);         /* mov eax, [ebp-0x26] */
            ii(0x1011_cb4f, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1011_cb56, 2);  if(jl(0x1011_cb5a, 2)) goto l_0x1011_cb5a;/* jl 0x1011cb5a */
        l_0x1011_cb58:
            ii(0x1011_cb58, 2);  jmp(0x1011_cb7a, 0x20); goto l_0x1011_cb7a;/* jmp 0x1011cb7a */
        l_0x1011_cb5a:
            ii(0x1011_cb5a, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_cb5e, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_cb61, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cb64, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_cb66, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_cb68, 4);  movsx(edx, memw[ss, ebp - 38]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1011_cb6c, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1011_cb6e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_cb70, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_cb72, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_cb75, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x1011_cb78, 2);  if(jl(0x1011_cb7c, 2)) goto l_0x1011_cb7c;/* jl 0x1011cb7c */
        l_0x1011_cb7a:
            ii(0x1011_cb7a, 2);  jmp(0x1011_cbf0, 0x74); goto l_0x1011_cbf0;/* jmp 0x1011cbf0 */
        l_0x1011_cb7c:
            ii(0x1011_cb7c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cb7f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_cb81, 3);  mov(bl, memb[ds, eax + 34]);          /* mov bl, [eax+0x22] */
            ii(0x1011_cb84, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1011_cb87, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1011_cb8a, 5);  call(0x1007_5e64, -0xa_6d2b);         /* call 0x10075e64 */
            ii(0x1011_cb8f, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1011_cb91, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1011_cb94, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1011_cb97, 5);  call(0x1007_5e64, -0xa_6d38);         /* call 0x10075e64 */
            ii(0x1011_cb9c, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1011_cb9e, 5);  call(0x1011_bf10, -0xc93);            /* call 0x1011bf10 */
            ii(0x1011_cba3, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_cba6, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_cbaa, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_cbac, 2);  if(jle(0x1011_cbf0, 0x42)) goto l_0x1011_cbf0;/* jle 0x1011cbf0 */
            ii(0x1011_cbae, 6);  test(memw[ss, ebp - 16], 1);          /* test word [ebp-0x10], 0x1 */
            ii(0x1011_cbb4, 2);  if(jz(0x1011_cbc9, 0x13)) goto l_0x1011_cbc9;/* jz 0x1011cbc9 */
            ii(0x1011_cbb6, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1011_cbba, 3);  lea(edx, memd[ds, edx + edx * 2]);    /* lea edx, [edx+edx*2] */
            ii(0x1011_cbbd, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_cbbf, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_cbc2, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1011_cbc4, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1011_cbc6, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1011_cbc9:
            ii(0x1011_cbc9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_cbcc, 1);  push(eax);                            /* push eax */
            ii(0x1011_cbcd, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1011_cbcf, 3);  mov(cl, memb[ss, ebp - 16]);          /* mov cl, [ebp-0x10] */
            ii(0x1011_cbd2, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_cbd5, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x1011_cbd8, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1011_cbdb, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1011_cbde, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1011_cbe1, 5);  call(0x1007_5e64, -0xa_6d82);         /* call 0x10075e64 */
            ii(0x1011_cbe6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_cbe8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_cbeb, 5);  call(0x1011_c2ed, -0x903);            /* call 0x1011c2ed */
        l_0x1011_cbf0:
            ii(0x1011_cbf0, 5);  jmp(0x1011_caef, -0x106); goto l_0x1011_caef;/* jmp 0x1011caef */
        l_0x1011_cbf5:
            ii(0x1011_cbf5, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
        l_0x1011_cbf9:
            ii(0x1011_cbf9, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1011_cbfc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_cbfe, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_cbff, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_cc00, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_cc01, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_cc02, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_cc03, 1);  ret();                                /* ret */
        }
    }
}
