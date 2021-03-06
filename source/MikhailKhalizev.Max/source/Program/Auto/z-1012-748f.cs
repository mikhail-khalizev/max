using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_748f-e23cfdac")]
        public void Method_1012_748f()
        {
            ii(0x1012_748f, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1012_7494, 5);  call(Definitions.sys_check_available_stack_size, 0x3_e8b9);/* call 0x10165d52 */
            ii(0x1012_7499, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_749a, 1);  push(esi);                            /* push esi */
            ii(0x1012_749b, 1);  push(edi);                            /* push edi */
            ii(0x1012_749c, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_749d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_749f, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1012_74a5, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_74a8, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1012_74ab, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_74ae, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x1012_74b3, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_74b7, 6);  mov(eax, memd[ds, eax + 0x101b_873d]);/* mov eax, [eax+0x101b873d] */
            ii(0x1012_74bd, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1012_74c0, 5);  call(0x100c_aafc, -0x5_c9c9);         /* call 0x100caafc */
            ii(0x1012_74c5, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_74c9, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1012_74cf, 7);  mov(memb[ds, eax + 0x101c_a490], 4);  /* mov byte [eax+0x101ca490], 0x4 */
            ii(0x1012_74d6, 7);  mov(memb[ds, 0x101c_59c9], 0);        /* mov byte [0x101c59c9], 0x0 */
            ii(0x1012_74dd, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_74e1, 2);  if(jz(0x1012_7506, 0x23)) goto l_0x1012_7506;/* jz 0x10127506 */
            ii(0x1012_74e3, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_74e7, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1012_74ea, 6);  push(memd[ds, eax + 0x101b_b444]);    /* push dword [eax+0x101bb444] */
            ii(0x1012_74f0, 5);  mov(eax, StringDefinitions.SDoesNotRespondTerminatingConnection);/* mov eax, 0x101a822b */
            ii(0x1012_74f5, 1);  push(eax);                            /* push eax */
            ii(0x1012_74f6, 5);  mov(eax, 0x101c_5e74);                /* mov eax, 0x101c5e74 */
            ii(0x1012_74fb, 1);  push(eax);                            /* push eax */
            ii(0x1012_74fc, 5);  call(Definitions.sys_sprintf, 0x3_ea00);/* call 0x10165f01 */
            ii(0x1012_7501, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1012_7504, 2);  jmp(0x1012_756e, 0x68); goto l_0x1012_756e;/* jmp 0x1012756e */
        l_0x1012_7506:
            ii(0x1012_7506, 7);  cmp(memb[ds, 0x101c_3984], 0);        /* cmp byte [0x101c3984], 0x0 */
            ii(0x1012_750d, 6);  if(jnz(0x1012_75e6, 0xd3)) goto l_0x1012_75e6;/* jnz 0x101275e6 */
            ii(0x1012_7513, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_7517, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1012_751a, 6);  push(memd[ds, eax + 0x101b_b444]);    /* push dword [eax+0x101bb444] */
            ii(0x1012_7520, 5);  mov(eax, StringDefinitions.SHasLeftTheGame);/* mov eax, 0x101a8258 */
            ii(0x1012_7525, 1);  push(eax);                            /* push eax */
            ii(0x1012_7526, 5);  mov(eax, 0x101c_5e74);                /* mov eax, 0x101c5e74 */
            ii(0x1012_752b, 1);  push(eax);                            /* push eax */
            ii(0x1012_752c, 5);  call(Definitions.sys_sprintf, 0x3_e9d0);/* call 0x10165f01 */
            ii(0x1012_7531, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1012_7534, 7);  mov(memd[ss, ebp - 16], 3);           /* mov dword [ebp-0x10], 0x3 */
            ii(0x1012_753b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_753e, 1);  inc(eax);                             /* inc eax */
            ii(0x1012_753f, 4);  imul(eax, memd[ss, ebp - 12]);        /* imul eax, [ebp-0xc] */
            ii(0x1012_7543, 5);  add(eax, 0x41b);                      /* add eax, 0x41b */
            ii(0x1012_7548, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_754b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_754e, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x1012_7551, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_7554, 5);  call(0x100d_5470, -0x5_20e9);         /* call 0x100d5470 */
            ii(0x1012_7559, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1012_755c, 4);  movsx(ebx, memw[ss, ebp - 24]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1012_7560, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_7564, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x1012_7569, 5);  call(0x1013_daea, 0x1_657c);          /* call 0x1013daea */
        l_0x1012_756e:
            ii(0x1012_756e, 7);  cmp(memb[ds, 0x101c_391e], 3);        /* cmp byte [0x101c391e], 0x3 */
            ii(0x1012_7575, 2);  if(jz(0x1012_759b, 0x24)) goto l_0x1012_759b;/* jz 0x1012759b */
            ii(0x1012_7577, 5);  call(0x100c_aa00, -0x5_cb7c);         /* call 0x100caa00 */
            ii(0x1012_757c, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_7581, 1);  push(eax);                            /* push eax */
            ii(0x1012_7582, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1012_7587, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1012_758c, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1012_7591, 5);  mov(eax, 0x101c_5e74);                /* mov eax, 0x101c5e74 */
            ii(0x1012_7596, 5);  call(0x1011_5d23, -0x1_1878);         /* call 0x10115d23 */
        l_0x1012_759b:
            ii(0x1012_759b, 7);  mov(memd[ss, ebp - 12], 4);           /* mov dword [ebp-0xc], 0x4 */
        l_0x1012_75a2:
            ii(0x1012_75a2, 3);  dec(memd[ss, ebp - 12]);              /* dec dword [ebp-0xc] */
            ii(0x1012_75a5, 5);  cmp(memw[ss, ebp - 12], -1 /* 0xff */);/* cmp word [ebp-0xc], 0xffff */
            ii(0x1012_75aa, 2);  if(jz(0x1012_75d0, 0x24)) goto l_0x1012_75d0;/* jz 0x101275d0 */
            ii(0x1012_75ac, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1012_75b0, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1012_75b6, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1012_75bc, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1012_75c1, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1012_75c4, 2);  if(jnz(0x1012_75ce, 8)) goto l_0x1012_75ce;/* jnz 0x101275ce */
            ii(0x1012_75c6, 6);  inc(memd[ds, 0x101c_5628]);           /* inc dword [0x101c5628] */
            ii(0x1012_75cc, 2);  jmp(0x1012_75e6, 0x18); goto l_0x1012_75e6;/* jmp 0x101275e6 */
        l_0x1012_75ce:
            ii(0x1012_75ce, 2);  jmp(0x1012_75a2, -0x2e); goto l_0x1012_75a2;/* jmp 0x101275a2 */
        l_0x1012_75d0:
            ii(0x1012_75d0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_75d2, 5);  mov(eax, 0x3e);                       /* mov eax, 0x3e */
            ii(0x1012_75d7, 5);  call(0x100c_aafc, -0x5_cae0);         /* call 0x100caafc */
            ii(0x1012_75dc, 10);  mov(memd[ds, 0x101c_5624], 0);       /* mov dword [0x101c5624], 0x0 */
        l_0x1012_75e6:
            ii(0x1012_75e6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_75e8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_75e9, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_75ea, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_75eb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_75ec, 1);  ret();                                /* ret */
        }
    }
}
