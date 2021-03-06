using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_fed0-cf8f43f9")]
        public void Method_100e_fed0()
        {
            ii(0x100e_fed0, 5);  push(0x50);                           /* push 0x50 */
            ii(0x100e_fed5, 5);  call(Definitions.sys_check_available_stack_size, 0x7_5e78);/* call 0x10165d52 */
            ii(0x100e_feda, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_fedb, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_fedc, 1);  push(esi);                            /* push esi */
            ii(0x100e_fedd, 1);  push(edi);                            /* push edi */
            ii(0x100e_fede, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_fedf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_fee1, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100e_fee7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_feea, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_feed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_fef0, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100e_fef3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_fef6, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_fefd, 2);  jmp(0x100e_ff05, 6); goto l_0x100e_ff05;/* jmp 0x100eff05 */
        l_0x100e_feff:
            ii(0x100e_feff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_ff02, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100e_ff05:
            ii(0x100e_ff05, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_ff08, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x100e_ff0b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_ff0e, 3);  cmp(eax, memd[ss, ebp - 16]);         /* cmp eax, [ebp-0x10] */
            ii(0x100e_ff11, 6);  if(jle(0x100f_0068, 0x151)) goto l_0x100f_0068;/* jle 0x100f0068 */
            ii(0x100e_ff17, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_ff1a, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_ff1d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_ff20, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100e_ff23, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_ff26, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_ff29, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_ff2b, 3);  add(memd[ss, ebp - 12], eax);         /* add [ebp-0xc], eax */
            ii(0x100e_ff2e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_ff31, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x100e_ff35, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_ff38, 5);  jmp(0x100f_0002, 0xc5); goto l_0x100f_0002;/* jmp 0x100f0002 */
        l_0x100e_ff3d:
            ii(0x100e_ff3d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_ff40, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ff43, 5);  call(0x100e_fdef, -0x159);            /* call 0x100efdef */
            ii(0x100e_ff48, 5);  jmp(0x100f_0063, 0x116); goto l_0x100f_0063;/* jmp 0x100f0063 */
        l_0x100e_ff4d:
            ii(0x100e_ff4d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_ff50, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ff53, 5);  call(0x100e_fbc0, -0x398);            /* call 0x100efbc0 */
            ii(0x100e_ff58, 5);  jmp(0x100f_0063, 0x106); goto l_0x100f_0063;/* jmp 0x100f0063 */
        l_0x100e_ff5d:
            ii(0x100e_ff5d, 2);  push(0);                              /* push 0x0 */
            ii(0x100e_ff5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ff62, 3);  mov(eax, memd[ds, eax + 99]);         /* mov eax, [eax+0x63] */
            ii(0x100e_ff65, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_ff68, 1);  push(eax);                            /* push eax */
            ii(0x100e_ff69, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ff6c, 3);  mov(ecx, memd[ds, eax + 97]);         /* mov ecx, [eax+0x61] */
            ii(0x100e_ff6f, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100e_ff72, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ff75, 3);  mov(ebx, memd[ds, eax + 84]);         /* mov ebx, [eax+0x54] */
            ii(0x100e_ff78, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ff7b, 3);  mov(edx, memd[ds, eax + 80]);         /* mov edx, [eax+0x50] */
            ii(0x100e_ff7e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ff81, 3);  mov(eax, memd[ds, eax + 72]);         /* mov eax, [eax+0x48] */
            ii(0x100e_ff84, 5);  call(/* sys */ 0x1016_71f0, 0x7_7267);/* call 0x101671f0 */
            ii(0x100e_ff89, 5);  jmp(0x100f_0063, 0xd5); goto l_0x100f_0063;/* jmp 0x100f0063 */
        l_0x100e_ff8e:
            ii(0x100e_ff8e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ff91, 3);  mov(eax, memd[ds, eax + 103]);        /* mov eax, [eax+0x67] */
            ii(0x100e_ff94, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_ff97, 1);  push(eax);                            /* push eax */
            ii(0x100e_ff98, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ff9b, 3);  push(memd[ds, eax + 76]);             /* push dword [eax+0x4c] */
            ii(0x100e_ff9e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ffa1, 3);  mov(eax, memd[ds, eax + 99]);         /* mov eax, [eax+0x63] */
            ii(0x100e_ffa4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_ffa7, 1);  push(eax);                            /* push eax */
            ii(0x100e_ffa8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ffab, 3);  mov(eax, memd[ds, eax + 97]);         /* mov eax, [eax+0x61] */
            ii(0x100e_ffae, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_ffb1, 1);  push(eax);                            /* push eax */
            ii(0x100e_ffb2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ffb5, 3);  mov(eax, memd[ds, eax + 97]);         /* mov eax, [eax+0x61] */
            ii(0x100e_ffb8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_ffbb, 1);  push(eax);                            /* push eax */
            ii(0x100e_ffbc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ffbf, 1);  push(eax);                            /* push eax */
            ii(0x100e_ffc0, 5);  call(/* sys */ 0x1016_abbc, 0x7_abf7);/* call 0x1016abbc */
            ii(0x100e_ffc5, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100e_ffc8, 5);  jmp(0x100f_0063, 0x96); goto l_0x100f_0063;/* jmp 0x100f0063 */
        l_0x100e_ffcd:
            ii(0x100e_ffcd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ffd0, 4);  cmp(memb[ds, eax + 111], 0);          /* cmp byte [eax+0x6f], 0x0 */
            ii(0x100e_ffd4, 2);  if(jz(0x100e_ffe3, 0xd)) goto l_0x100e_ffe3;/* jz 0x100effe3 */
            ii(0x100e_ffd6, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100e_ffdb, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ffde, 5);  call(0x100e_fd1d, -0x2c6);            /* call 0x100efd1d */
        l_0x100e_ffe3:
            ii(0x100e_ffe3, 5);  jmp(0x100f_0063, 0x7b); goto l_0x100f_0063;/* jmp 0x100f0063 */
        l_0x100e_ffe8:
            ii(0x100e_ffe8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_ffeb, 4);  cmp(memb[ds, eax + 111], 0);          /* cmp byte [eax+0x6f], 0x0 */
            ii(0x100e_ffef, 2);  if(jz(0x100e_fffb, 0xa)) goto l_0x100e_fffb;/* jz 0x100efffb */
            ii(0x100e_fff1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_fff3, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_fff6, 5);  call(0x100e_fd1d, -0x2de);            /* call 0x100efd1d */
        l_0x100e_fffb:
            ii(0x100e_fffb, 5);  jmp(0x100f_0063, 0x63); goto l_0x100f_0063;/* jmp 0x100f0063 */
        l_0x100f_0000:
            ii(0x100f_0000, 2);  jmp(0x100f_0063, 0x61); goto l_0x100f_0063;/* jmp 0x100f0063 */
        l_0x100f_0002:
            ii(0x100f_0002, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100f_0005, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100f_0008, 5);  cmp(memw[ss, ebp - 32], 0xb);         /* cmp word [ebp-0x20], 0xb */
            ii(0x100f_000d, 2);  if(jb(0x100f_0042, 0x33)) goto l_0x100f_0042;/* jb 0x100f0042 */
            ii(0x100f_000f, 5);  cmp(memw[ss, ebp - 32], 0xb);         /* cmp word [ebp-0x20], 0xb */
            ii(0x100f_0014, 2);  if(jbe(0x100e_ffe8, -0x2e)) goto l_0x100e_ffe8;/* jbe 0x100effe8 */
            ii(0x100f_0016, 5);  cmp(memw[ss, ebp - 32], 0xf);         /* cmp word [ebp-0x20], 0xf */
            ii(0x100f_001b, 2);  if(jb(0x100f_0035, 0x18)) goto l_0x100f_0035;/* jb 0x100f0035 */
            ii(0x100f_001d, 5);  cmp(memw[ss, ebp - 32], 0xf);         /* cmp word [ebp-0x20], 0xf */
            ii(0x100f_0022, 6);  if(jbe(0x100e_ff3d, -0xeb)) goto l_0x100e_ff3d;/* jbe 0x100eff3d */
            ii(0x100f_0028, 5);  cmp(memw[ss, ebp - 32], 0x10);        /* cmp word [ebp-0x20], 0x10 */
            ii(0x100f_002d, 6);  if(jz(0x100e_ff8e, -0xa5)) goto l_0x100e_ff8e;/* jz 0x100eff8e */
            ii(0x100f_0033, 2);  jmp(0x100f_0000, -0x35); goto l_0x100f_0000;/* jmp 0x100f0000 */
        l_0x100f_0035:
            ii(0x100f_0035, 5);  cmp(memw[ss, ebp - 32], 0xd);         /* cmp word [ebp-0x20], 0xd */
            ii(0x100f_003a, 6);  if(jz(0x100e_ff5d, -0xe3)) goto l_0x100e_ff5d;/* jz 0x100eff5d */
            ii(0x100f_0040, 2);  jmp(0x100f_0000, -0x42); goto l_0x100f_0000;/* jmp 0x100f0000 */
        l_0x100f_0042:
            ii(0x100f_0042, 5);  cmp(memw[ss, ebp - 32], 4);           /* cmp word [ebp-0x20], 0x4 */
            ii(0x100f_0047, 2);  if(jb(0x100f_0061, 0x18)) goto l_0x100f_0061;/* jb 0x100f0061 */
            ii(0x100f_0049, 5);  cmp(memw[ss, ebp - 32], 4);           /* cmp word [ebp-0x20], 0x4 */
            ii(0x100f_004e, 6);  if(jbe(0x100e_ffcd, -0x87)) goto l_0x100e_ffcd;/* jbe 0x100effcd */
            ii(0x100f_0054, 5);  cmp(memw[ss, ebp - 32], 7);           /* cmp word [ebp-0x20], 0x7 */
            ii(0x100f_0059, 6);  if(jz(0x100e_ff4d, -0x112)) goto l_0x100e_ff4d;/* jz 0x100eff4d */
            ii(0x100f_005f, 2);  jmp(0x100f_0000, -0x61); goto l_0x100f_0000;/* jmp 0x100f0000 */
        l_0x100f_0061:
            ii(0x100f_0061, 2);  jmp(0x100f_0000, -0x63); goto l_0x100f_0000;/* jmp 0x100f0000 */
        l_0x100f_0063:
            ii(0x100f_0063, 5);  jmp(0x100e_feff, -0x169); goto l_0x100e_feff;/* jmp 0x100efeff */
        l_0x100f_0068:
            ii(0x100f_0068, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_006b, 4);  cmp(memd[ds, eax + 72], 0);           /* cmp dword [eax+0x48], 0x0 */
            ii(0x100f_006f, 2);  if(jz(0x100f_0082, 0x11)) goto l_0x100f_0082;/* jz 0x100f0082 */
            ii(0x100f_0071, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_0074, 3);  add(edx, 0x50);                       /* add edx, 0x50 */
            ii(0x100f_0077, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_007a, 3);  mov(eax, memd[ds, eax + 72]);         /* mov eax, [eax+0x48] */
            ii(0x100f_007d, 5);  call(Definitions.sys_display_draw_1, 0x7_7426);/* call 0x101674a8 */
        l_0x100f_0082:
            ii(0x100f_0082, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_0084, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_0085, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_0086, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_0087, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_0088, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_0089, 1);  ret();                                /* ret */
        }
    }
}
