using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_0958-65b65d41")]
        public void Method_1014_0958()
        {
            ii(0x1014_0958, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1014_095d, 5);  call(Definitions.sys_check_available_stack_size, 0x2_53f0);/* call 0x10165d52 */
            ii(0x1014_0962, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_0963, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_0964, 1);  push(edx);                            /* push edx */
            ii(0x1014_0965, 1);  push(esi);                            /* push esi */
            ii(0x1014_0966, 1);  push(edi);                            /* push edi */
            ii(0x1014_0967, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_0968, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_096a, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_0970, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_0973, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1014_0978, 5);  call(/* sys */ 0x1016_a24c, 0x2_98cf);/* call 0x1016a24c */
            ii(0x1014_097d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_0980, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0983, 3);  mov(eax, memd[ds, eax + 44]);         /* mov eax, [eax+0x2c] */
            ii(0x1014_0986, 5);  call(0x100d_7f6c, -0x6_8a1f);         /* call 0x100d7f6c */
            ii(0x1014_098b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_098e, 4);  mov(ax, memw[ds, eax + 38]);          /* mov ax, [eax+0x26] */
            ii(0x1014_0992, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_0995, 4);  add(ax, memw[ds, edx + 42]);          /* add ax, [edx+0x2a] */
            ii(0x1014_0999, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_099c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_099f, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x1014_09a2, 5);  call(Definitions.my_1_get_count, -0x9_54cf);/* call 0x100ab4d8 */
            ii(0x1014_09a7, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1014_09ab, 2);  if(jle(0x1014_09cc, 0x1f)) goto l_0x1014_09cc;/* jle 0x101409cc */
            ii(0x1014_09ad, 5);  call(0x100d_51e4, -0x6_b7ce);         /* call 0x100d51e4 */
            ii(0x1014_09b2, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1014_09b4, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1014_09b6, 5);  call(0x100d_5204, -0x6_b7b7);         /* call 0x100d5204 */
            ii(0x1014_09bb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_09bd, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1014_09bf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_09c2, 3);  mov(eax, memd[ds, eax + 52]);         /* mov eax, [eax+0x34] */
            ii(0x1014_09c5, 5);  call(0x100c_fa7c, -0x7_0f4e);         /* call 0x100cfa7c */
            ii(0x1014_09ca, 2);  jmp(0x1014_09ee, 0x22); goto l_0x1014_09ee;/* jmp 0x101409ee */
        l_0x1014_09cc:
            ii(0x1014_09cc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_09cf, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x1014_09d2, 5);  call(Definitions.my_1_get_count, -0x9_54ff);/* call 0x100ab4d8 */
            ii(0x1014_09d7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_09da, 5);  call(0x100d_51c4, -0x6_b81b);         /* call 0x100d51c4 */
            ii(0x1014_09df, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_09e1, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1014_09e3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_09e6, 3);  mov(eax, memd[ds, eax + 52]);         /* mov eax, [eax+0x34] */
            ii(0x1014_09e9, 5);  call(0x100c_fb06, -0x7_0ee8);         /* call 0x100cfb06 */
        l_0x1014_09ee:
            ii(0x1014_09ee, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_09f1, 3);  mov(eax, memd[ds, eax + 36]);         /* mov eax, [eax+0x24] */
            ii(0x1014_09f4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_09f7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1014_09f9, 2);  if(jnz(0x1014_0a11, 0x16)) goto l_0x1014_0a11;/* jnz 0x10140a11 */
            ii(0x1014_09fb, 5);  call(0x100d_51c4, -0x6_b83c);         /* call 0x100d51c4 */
            ii(0x1014_0a00, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_0a02, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1014_0a04, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0a07, 3);  mov(eax, memd[ds, eax + 48]);         /* mov eax, [eax+0x30] */
            ii(0x1014_0a0a, 5);  call(0x100c_fb06, -0x7_0f09);         /* call 0x100cfb06 */
            ii(0x1014_0a0f, 2);  jmp(0x1014_0a2e, 0x1d); goto l_0x1014_0a2e;/* jmp 0x10140a2e */
        l_0x1014_0a11:
            ii(0x1014_0a11, 5);  call(0x100d_51e4, -0x6_b832);         /* call 0x100d51e4 */
            ii(0x1014_0a16, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1014_0a18, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1014_0a1a, 5);  call(0x100d_5204, -0x6_b81b);         /* call 0x100d5204 */
            ii(0x1014_0a1f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_0a21, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1014_0a23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0a26, 3);  mov(eax, memd[ds, eax + 48]);         /* mov eax, [eax+0x30] */
            ii(0x1014_0a29, 5);  call(0x100c_fa7c, -0x7_0fb2);         /* call 0x100cfa7c */
        l_0x1014_0a2e:
            ii(0x1014_0a2e, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1014_0a35, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0a38, 4);  mov(ax, memw[ds, eax + 38]);          /* mov ax, [eax+0x26] */
            ii(0x1014_0a3c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_0a3f, 2);  jmp(0x1014_0a47, 6); goto l_0x1014_0a47;/* jmp 0x10140a47 */
        l_0x1014_0a41:
            ii(0x1014_0a41, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0a44, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1014_0a47:
            ii(0x1014_0a47, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0a4a, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1014_0a4e, 6);  if(jge(0x1014_0af8, 0xa4)) goto l_0x1014_0af8;/* jge 0x10140af8 */
            ii(0x1014_0a54, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0a57, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_0a5a, 4);  cmp(ax, memw[ds, edx + 40]);          /* cmp ax, [edx+0x28] */
            ii(0x1014_0a5e, 2);  if(jge(0x1014_0a8a, 0x2a)) goto l_0x1014_0a8a;/* jge 0x10140a8a */
            ii(0x1014_0a60, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1014_0a65, 1);  push(eax);                            /* push eax */
            ii(0x1014_0a66, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_0a6a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0a6d, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x1014_0a70, 5);  call(0x1014_159c, 0xb27);             /* call 0x1014159c */
            ii(0x1014_0a75, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1014_0a77, 5);  mov(ebx, StringDefinitions.Parent);   /* mov ebx, 0x101ace31 */
            ii(0x1014_0a7c, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1014_0a80, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0a83, 5);  call(0x1014_0845, -0x243);            /* call 0x10140845 */
            ii(0x1014_0a88, 2);  jmp(0x1014_0ae8, 0x5e); goto l_0x1014_0ae8;/* jmp 0x10140ae8 */
        l_0x1014_0a8a:
            ii(0x1014_0a8a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0a8d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_0a90, 4);  cmp(ax, memw[ds, edx + 40]);          /* cmp ax, [edx+0x28] */
            ii(0x1014_0a94, 2);  if(jnz(0x1014_0ac0, 0x2a)) goto l_0x1014_0ac0;/* jnz 0x10140ac0 */
            ii(0x1014_0a96, 5);  mov(eax, 0x30);                       /* mov eax, 0x30 */
            ii(0x1014_0a9b, 1);  push(eax);                            /* push eax */
            ii(0x1014_0a9c, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_0aa0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0aa3, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x1014_0aa6, 5);  call(0x1014_159c, 0xaf1);             /* call 0x1014159c */
            ii(0x1014_0aab, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1014_0aad, 5);  mov(ebx, StringDefinitions.Task);     /* mov ebx, 0x101ace3a */
            ii(0x1014_0ab2, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1014_0ab6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0ab9, 5);  call(0x1014_0845, -0x279);            /* call 0x10140845 */
            ii(0x1014_0abe, 2);  jmp(0x1014_0ae8, 0x28); goto l_0x1014_0ae8;/* jmp 0x10140ae8 */
        l_0x1014_0ac0:
            ii(0x1014_0ac0, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x1014_0ac5, 1);  push(eax);                            /* push eax */
            ii(0x1014_0ac6, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_0aca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0acd, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x1014_0ad0, 5);  call(0x1014_159c, 0xac7);             /* call 0x1014159c */
            ii(0x1014_0ad5, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1014_0ad7, 5);  mov(ebx, StringDefinitions.Child);    /* mov ebx, 0x101ace41 */
            ii(0x1014_0adc, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1014_0ae0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0ae3, 5);  call(0x1014_0845, -0x2a3);            /* call 0x10140845 */
        l_0x1014_0ae8:
            ii(0x1014_0ae8, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1014_0aee, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1014_0af0, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
            ii(0x1014_0af3, 5);  jmp(0x1014_0a41, -0xb7); goto l_0x1014_0a41;/* jmp 0x10140a41 */
        l_0x1014_0af8:
            ii(0x1014_0af8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0afb, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1014_0afe, 5);  call(Definitions.sys_display_draw_0, 0x2_6981);/* call 0x10167484 */
            ii(0x1014_0b03, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_0b05, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_0b06, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_0b07, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_0b08, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_0b09, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_0b0a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_0b0b, 1);  ret();                                /* ret */
        }
    }
}
