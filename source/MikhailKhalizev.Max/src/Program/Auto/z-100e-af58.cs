using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_af58-bf39d305")]
        public void Method_100e_af58()
        {
            ii(0x100e_af58, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100e_af5d, 5);  call(Definitions.sys_check_available_stack_size, 0x7_adf0);/* call 0x10165d52 */
            ii(0x100e_af62, 1);  push(esi);                            /* push esi */
            ii(0x100e_af63, 1);  push(edi);                            /* push edi */
            ii(0x100e_af64, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_af65, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_af67, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100e_af6d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_af70, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100e_af73, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100e_af76, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100e_af79, 3);  mov(eax, memd[ss, ebp + 36]);         /* mov eax, [ebp+0x24] */
            ii(0x100e_af7c, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_af7f, 4);  mov(memw[ds, edx + 51], ax);          /* mov [edx+0x33], ax */
            ii(0x100e_af83, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_af86, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100e_af89, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_af8c, 5);  call(/* sys */ 0x1016_a24c, 0x7_f2bb);/* call 0x1016a24c */
            ii(0x100e_af91, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100e_af97, 4);  movsx(edx, memw[ss, ebp + 28]);       /* movsx edx, word [ebp+0x1c] */
            ii(0x100e_af9b, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100e_af9d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_af9f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_afa2, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_afa4, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_afa6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_afa8, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_afac, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100e_afae, 3);  mov(memd[ss, ebp + 20], eax);         /* mov [ebp+0x14], eax */
            ii(0x100e_afb1, 5);  mov(ecx, 6);                          /* mov ecx, 0x6 */
            ii(0x100e_afb6, 3);  mov(edi, memd[ss, ebp - 16]);         /* mov edi, [ebp-0x10] */
            ii(0x100e_afb9, 3);  mov(esi, memd[ss, ebp - 12]);         /* mov esi, [ebp-0xc] */
            ii(0x100e_afbc, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x100e_afbe, 2);  movsw();                              /* movsw */
            ii(0x100e_afc0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_afc3, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100e_afc6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_afc9, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x100e_afcd, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100e_afd0, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100e_afd4, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_afd6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_afd9, 3);  add(memd[ds, eax + 22], edx);         /* add [eax+0x16], edx */
            ii(0x100e_afdc, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100e_afe0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_afe3, 2);  add(memd[ds, eax], edx);              /* add [eax], edx */
            ii(0x100e_afe5, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x100e_afe9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_afec, 3);  add(memd[ds, eax + 4], edx);          /* add [eax+0x4], edx */
            ii(0x100e_afef, 4);  movsx(edx, memw[ss, ebp + 24]);       /* movsx edx, word [ebp+0x18] */
            ii(0x100e_aff3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_aff6, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_aff8, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100e_affa, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_affd, 3);  mov(memd[ds, edx + 8], eax);          /* mov [edx+0x8], eax */
            ii(0x100e_b000, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100e_b006, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_b008, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_b00b, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100e_b00e, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100e_b010, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_b013, 3);  mov(memd[ds, edx + 12], eax);         /* mov [edx+0xc], eax */
            ii(0x100e_b016, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_b01a, 5);  call(Definitions.sys_new_arr, 0x7_aff1);/* call 0x10166010 */
            ii(0x100e_b01f, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_b022, 3);  mov(memd[ds, edx + 35], eax);         /* mov [edx+0x23], eax */
            ii(0x100e_b025, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_b029, 5);  call(Definitions.sys_new_arr, 0x7_afe2);/* call 0x10166010 */
            ii(0x100e_b02e, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_b031, 3);  mov(memd[ds, edx + 39], eax);         /* mov [edx+0x27], eax */
            ii(0x100e_b034, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_b037, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_b03a, 4);  mov(memw[ds, edx + 46], ax);          /* mov [edx+0x2e], ax */
            ii(0x100e_b03e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_b041, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_b044, 3);  mov(eax, memd[ds, eax + 35]);         /* mov eax, [eax+0x23] */
            ii(0x100e_b047, 5);  call(Definitions.sys_strcpy, 0x7_ae83);/* call 0x10165ecf */
            ii(0x100e_b04c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_b04f, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_b052, 3);  mov(memd[ds, edx + 31], eax);         /* mov [edx+0x1f], eax */
            ii(0x100e_b055, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_b058, 4);  mov(memb[ds, eax + 26], 0);           /* mov byte [eax+0x1a], 0x0 */
            ii(0x100e_b05c, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x100e_b061, 5);  call(Definitions.sys_new, 0x7_ad9a);  /* call 0x10165e00 */
            ii(0x100e_b066, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_b069, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_b06c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_b06f, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100e_b073, 2);  if(jz(0x100e_b098, 0x23)) goto l_0x100e_b098;/* jz 0x100eb098 */
            ii(0x100e_b075, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100e_b07b, 1);  cwde();                               /* cwde */
            ii(0x100e_b07c, 1);  push(eax);                            /* push eax */
            ii(0x100e_b07d, 4);  movsx(ecx, memw[ss, ebp + 24]);       /* movsx ecx, word [ebp+0x18] */
            ii(0x100e_b081, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_b083, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_b085, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_b088, 5);  call(0x100d_7bdc, -0x1_34b1);         /* call 0x100d7bdc */
            ii(0x100e_b08d, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_b090, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_b093, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_b096, 2);  jmp(0x100e_b09e, 6); goto l_0x100e_b09e;/* jmp 0x100eb09e */
        l_0x100e_b098:
            ii(0x100e_b098, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_b09b, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x100e_b09e:
            ii(0x100e_b09e, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_b0a1, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_b0a4, 3);  mov(memd[ds, edx + 27], eax);         /* mov [edx+0x1b], eax */
            ii(0x100e_b0a7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_b0aa, 4);  mov(memb[ds, eax + 43], 0);           /* mov byte [eax+0x2b], 0x0 */
            ii(0x100e_b0ae, 3);  mov(eax, memd[ss, ebp + 32]);         /* mov eax, [ebp+0x20] */
            ii(0x100e_b0b1, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100e_b0b4, 4);  mov(memw[ds, edx + 48], ax);          /* mov [edx+0x30], ax */
            ii(0x100e_b0b8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_b0bb, 4);  mov(memb[ds, eax + 50], 1);           /* mov byte [eax+0x32], 0x1 */
            ii(0x100e_b0bf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_b0c2, 4);  mov(memb[ds, eax + 53], 0);           /* mov byte [eax+0x35], 0x0 */
            ii(0x100e_b0c6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_b0c9, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100e_b0cc, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100e_b0cf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_b0d1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_b0d2, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_b0d3, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_b0d4, 3);  ret(0x18);                            /* ret 0x18 */
        }
    }
}
