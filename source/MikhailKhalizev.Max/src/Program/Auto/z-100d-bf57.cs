using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_bf57-454826ea")]
        public void Method_100d_bf57()
        {
            ii(0x100d_bf57, 5);  push(0x16c);                          /* push 0x16c */
            ii(0x100d_bf5c, 5);  call(Definitions.sys_check_available_stack_size, 0x8_9df1);/* call 0x10165d52 */
            ii(0x100d_bf61, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_bf62, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_bf63, 1);  push(edx);                            /* push edx */
            ii(0x100d_bf64, 1);  push(esi);                            /* push esi */
            ii(0x100d_bf65, 1);  push(edi);                            /* push edi */
            ii(0x100d_bf66, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_bf67, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_bf69, 6);  sub(esp, 0x134);                      /* sub esp, 0x134 */
            ii(0x100d_bf6f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_bf72, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bf75, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x100d_bf79, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_bf7c, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x100d_bf80, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_bf83, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bf86, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x100d_bf89, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_bf8c, 1);  push(eax);                            /* push eax */
            ii(0x100d_bf8d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bf90, 3);  push(memd[ds, eax + 26]);             /* push dword [eax+0x1a] */
            ii(0x100d_bf93, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bf96, 3);  mov(eax, memd[ds, eax + 42]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_bf99, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100d_bf9c, 1);  push(eax);                            /* push eax */
            ii(0x100d_bf9d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bfa0, 3);  mov(eax, memd[ds, eax + 42]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_bfa3, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100d_bfa5, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_bfa8, 1);  push(eax);                            /* push eax */
            ii(0x100d_bfa9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bfac, 3);  mov(eax, memd[ds, eax + 42]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_bfaf, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100d_bfb2, 1);  push(eax);                            /* push eax */
            ii(0x100d_bfb3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bfb6, 3);  mov(eax, memd[ds, eax + 42]);         /* mov eax, [eax+0x2a] */
            ii(0x100d_bfb9, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x100d_bfbc, 1);  push(eax);                            /* push eax */
            ii(0x100d_bfbd, 5);  call(/* sys */ 0x1016_abbc, 0x8_ebfa);/* call 0x1016abbc */
            ii(0x100d_bfc2, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100d_bfc5, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_bfcc, 2);  jmp(0x100d_bfd4, 6); goto l_0x100d_bfd4;/* jmp 0x100dbfd4 */
        l_0x100d_bfce:
            ii(0x100d_bfce, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_bfd1, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100d_bfd4:
            ii(0x100d_bfd4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_bfd7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_bfda, 4);  cmp(ax, memw[ds, edx + 40]);          /* cmp ax, [edx+0x28] */
            ii(0x100d_bfde, 2);  if(jge(0x100d_bfff, 0x1f)) goto l_0x100d_bfff;/* jge 0x100dbfff */
            ii(0x100d_bfe0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bfe3, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x100d_bfe6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_bfe9, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_bfed, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_bfef, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_bff2, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_bff5, 5);  call(Definitions.my_2_get_count, -0x5_0c92);/* call 0x1008b368 */
            ii(0x100d_bffa, 1);  cwde();                               /* cwde */
            ii(0x100d_bffb, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_bffd, 2);  if(jl(0x100d_c004, 5)) goto l_0x100d_c004;/* jl 0x100dc004 */
        l_0x100d_bfff:
            ii(0x100d_bfff, 5);  jmp(0x100d_c257, 0x253); goto l_0x100d_c257;/* jmp 0x100dc257 */
        l_0x100d_c004:
            ii(0x100d_c004, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c007, 4);  mov(ax, memw[ds, eax + 36]);          /* mov ax, [eax+0x24] */
            ii(0x100d_c00b, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x100d_c00e, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_c011, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c014, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_c017, 5);  call(0x1008_b228, -0x5_0df4);         /* call 0x1008b228 */
            ii(0x100d_c01c, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_c01f, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_c022, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_c025, 3);  shl(eax, 5);                          /* shl eax, 0x5 */
            ii(0x100d_c028, 5);  add(eax, 0x10);                       /* add eax, 0x10 */
            ii(0x100d_c02d, 1);  cwde();                               /* cwde */
            ii(0x100d_c02e, 1);  push(eax);                            /* push eax */
            ii(0x100d_c02f, 5);  mov(eax, 0x10);                       /* mov eax, 0x10 */
            ii(0x100d_c034, 1);  push(eax);                            /* push eax */
            ii(0x100d_c035, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_c037, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100d_c03c, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100d_c03f, 4);  movsx(ebx, memw[ss, ebp - 28]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x100d_c043, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c046, 3);  mov(edx, memd[ds, edx + 18]);         /* mov edx, [edx+0x12] */
            ii(0x100d_c049, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_c04c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c04f, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_c052, 5);  call(0x1012_b6af, 0x4_f658);          /* call 0x1012b6af */
            ii(0x100d_c057, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_c05b, 3);  imul(edx, edx, 0x33);                 /* imul edx, edx, 0x33 */
            ii(0x100d_c05e, 6);  mov(edx, memd[ds, edx + 0x101c_81d7]);/* mov edx, [edx+0x101c81d7] */
            ii(0x100d_c064, 6);  lea(eax, memd[ss, ebp - 228]);        /* lea eax, [ebp-0xe4] */
            ii(0x100d_c06a, 5);  call(Definitions.sys_strcpy, 0x8_9e60);/* call 0x10165ecf */
            ii(0x100d_c06f, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x100d_c076, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_c07d, 2);  jmp(0x100d_c085, 6); goto l_0x100d_c085;/* jmp 0x100dc085 */
        l_0x100d_c07f:
            ii(0x100d_c07f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_c082, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x100d_c085:
            ii(0x100d_c085, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c088, 3);  mov(edx, memd[ds, eax + 34]);         /* mov edx, [eax+0x22] */
            ii(0x100d_c08b, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_c08e, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100d_c092, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_c094, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100d_c098, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_c09a, 2);  if(jge(0x100d_c0bc, 0x20)) goto l_0x100d_c0bc;/* jge 0x100dc0bc */
            ii(0x100d_c09c, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100d_c0a0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c0a3, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_c0a6, 5);  call(0x1008_b228, -0x5_0e83);         /* call 0x1008b228 */
            ii(0x100d_c0ab, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_c0ae, 4);  cmp(ax, memw[ss, ebp - 28]);          /* cmp ax, [ebp-0x1c] */
            ii(0x100d_c0b2, 2);  if(jnz(0x100d_c0ba, 6)) goto l_0x100d_c0ba;/* jnz 0x100dc0ba */
            ii(0x100d_c0b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_c0b7, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100d_c0ba:
            ii(0x100d_c0ba, 2);  jmp(0x100d_c07f, -0x3d); goto l_0x100d_c07f;/* jmp 0x100dc07f */
        l_0x100d_c0bc:
            ii(0x100d_c0bc, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_c0c0, 1);  push(eax);                            /* push eax */
            ii(0x100d_c0c1, 5);  mov(eax, StringDefinitions.I15);      /* mov eax, 0x101a1a11 */
            ii(0x100d_c0c6, 1);  push(eax);                            /* push eax */
            ii(0x100d_c0c7, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x100d_c0cc, 1);  push(eax);                            /* push eax */
            ii(0x100d_c0cd, 6);  lea(eax, memd[ss, ebp - 232]);        /* lea eax, [ebp-0xe8] */
            ii(0x100d_c0d3, 5);  call(Definitions.my_string_ctor, 0x6_5a10);/* call 0x10141ae8 */
            ii(0x100d_c0d8, 1);  push(eax);                            /* push eax */
            ii(0x100d_c0d9, 5);  call(0x1014_2037, 0x6_5f59);          /* call 0x10142037 */
            ii(0x100d_c0de, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x100d_c0e1, 5);  call(Definitions.my_strobj_c_str_v2, -0x5_291e);/* call 0x100897c8 */
            ii(0x100d_c0e6, 6);  lea(ebx, memd[ss, ebp - 228]);        /* lea ebx, [ebp-0xe4] */
            ii(0x100d_c0ec, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_c0ee, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100d_c0f0, 5);  call(Definitions.sys_strcat, 0x8_9e3c);/* call 0x10165f31 */
            ii(0x100d_c0f5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c0f7, 6);  lea(eax, memd[ss, ebp - 232]);        /* lea eax, [ebp-0xe8] */
            ii(0x100d_c0fd, 5);  call(Definitions.my_string_dtor, 0x6_5a28);/* call 0x10141b2a */
            ii(0x100d_c102, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_c106, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c109, 3);  mov(eax, memd[ds, eax + 68]);         /* mov eax, [eax+0x44] */
            ii(0x100d_c10c, 5);  call(0x100e_0878, 0x4767);            /* call 0x100e0878 */
            ii(0x100d_c111, 4);  mov(ax, memw[ds, eax + 25]);          /* mov ax, [eax+0x19] */
            ii(0x100d_c115, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_c118, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c11b, 4);  mov(ax, memw[ds, eax + 36]);          /* mov ax, [eax+0x24] */
            ii(0x100d_c11f, 3);  add(eax, memd[ss, ebp - 16]);         /* add eax, [ebp-0x10] */
            ii(0x100d_c122, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_c125, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c128, 3);  add(eax, 0x48);                       /* add eax, 0x48 */
            ii(0x100d_c12b, 5);  call(0x100e_08bc, 0x478c);            /* call 0x100e08bc */
            ii(0x100d_c130, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_c133, 6);  mov(memd[ss, ebp - 236], eax);        /* mov [ebp-0xec], eax */
            ii(0x100d_c139, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100d_c13d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_c13f, 6);  if(jle(0x100d_c200, 0xbb)) goto l_0x100d_c200;/* jle 0x100dc200 */
            ii(0x100d_c145, 7);  movsx(eax, memw[ss, ebp - 236]);      /* movsx eax, word [ebp-0xec] */
            ii(0x100d_c14c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_c14e, 2);  if(jnz(0x100d_c165, 0x15)) goto l_0x100d_c165;/* jnz 0x100dc165 */
            ii(0x100d_c150, 5);  mov(edx, StringDefinitions.Empty63);  /* mov edx, 0x101a1a15 */
            ii(0x100d_c155, 6);  lea(eax, memd[ss, ebp - 228]);        /* lea eax, [ebp-0xe4] */
            ii(0x100d_c15b, 5);  call(Definitions.sys_strcat, 0x8_9dd1);/* call 0x10165f31 */
            ii(0x100d_c160, 5);  jmp(0x100d_c200, 0x9b); goto l_0x100d_c200;/* jmp 0x100dc200 */
        l_0x100d_c165:
            ii(0x100d_c165, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_c168, 7);  cmp(ax, memw[ss, ebp - 236]);         /* cmp ax, [ebp-0xec] */
            ii(0x100d_c16f, 2);  if(jg(0x100d_c186, 0x15)) goto l_0x100d_c186;/* jg 0x100dc186 */
            ii(0x100d_c171, 5);  mov(edx, StringDefinitions.Full);     /* mov edx, 0x101a1a1e */
            ii(0x100d_c176, 6);  lea(eax, memd[ss, ebp - 228]);        /* lea eax, [ebp-0xe4] */
            ii(0x100d_c17c, 5);  call(Definitions.sys_strcat, 0x8_9db0);/* call 0x10165f31 */
            ii(0x100d_c181, 5);  jmp(0x100d_c200, 0x7a); goto l_0x100d_c200;/* jmp 0x100dc200 */
        l_0x100d_c186:
            ii(0x100d_c186, 5);  cmp(memw[ss, ebp - 28], 0x40);        /* cmp word [ebp-0x1c], 0x40 */
            ii(0x100d_c18b, 2);  if(jnz(0x100d_c1ac, 0x1f)) goto l_0x100d_c1ac;/* jnz 0x100dc1ac */
            ii(0x100d_c18d, 7);  movsx(eax, memw[ss, ebp - 236]);      /* movsx eax, word [ebp-0xec] */
            ii(0x100d_c194, 1);  push(eax);                            /* push eax */
            ii(0x100d_c195, 5);  mov(eax, StringDefinitions.IFuel);    /* mov eax, 0x101a1a26 */
            ii(0x100d_c19a, 1);  push(eax);                            /* push eax */
            ii(0x100d_c19b, 6);  lea(eax, memd[ss, ebp - 288]);        /* lea eax, [ebp-0x120] */
            ii(0x100d_c1a1, 1);  push(eax);                            /* push eax */
            ii(0x100d_c1a2, 5);  call(Definitions.sys_sprintf, 0x8_9d5a);/* call 0x10165f01 */
            ii(0x100d_c1a7, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100d_c1aa, 2);  jmp(0x100d_c1ef, 0x43); goto l_0x100d_c1ef;/* jmp 0x100dc1ef */
        l_0x100d_c1ac:
            ii(0x100d_c1ac, 5);  cmp(memw[ss, ebp - 28], 0x3c);        /* cmp word [ebp-0x1c], 0x3c */
            ii(0x100d_c1b1, 2);  if(jnz(0x100d_c1d2, 0x1f)) goto l_0x100d_c1d2;/* jnz 0x100dc1d2 */
            ii(0x100d_c1b3, 7);  movsx(eax, memw[ss, ebp - 236]);      /* movsx eax, word [ebp-0xec] */
            ii(0x100d_c1ba, 1);  push(eax);                            /* push eax */
            ii(0x100d_c1bb, 5);  mov(eax, StringDefinitions.IGold);    /* mov eax, 0x101a1a31 */
            ii(0x100d_c1c0, 1);  push(eax);                            /* push eax */
            ii(0x100d_c1c1, 6);  lea(eax, memd[ss, ebp - 288]);        /* lea eax, [ebp-0x120] */
            ii(0x100d_c1c7, 1);  push(eax);                            /* push eax */
            ii(0x100d_c1c8, 5);  call(Definitions.sys_sprintf, 0x8_9d34);/* call 0x10165f01 */
            ii(0x100d_c1cd, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x100d_c1d0, 2);  jmp(0x100d_c1ef, 0x1d); goto l_0x100d_c1ef;/* jmp 0x100dc1ef */
        l_0x100d_c1d2:
            ii(0x100d_c1d2, 7);  movsx(eax, memw[ss, ebp - 236]);      /* movsx eax, word [ebp-0xec] */
            ii(0x100d_c1d9, 1);  push(eax);                            /* push eax */
            ii(0x100d_c1da, 5);  mov(eax, StringDefinitions.IMat);     /* mov eax, 0x101a1a3c */
            ii(0x100d_c1df, 1);  push(eax);                            /* push eax */
            ii(0x100d_c1e0, 6);  lea(eax, memd[ss, ebp - 288]);        /* lea eax, [ebp-0x120] */
            ii(0x100d_c1e6, 1);  push(eax);                            /* push eax */
            ii(0x100d_c1e7, 5);  call(Definitions.sys_sprintf, 0x8_9d15);/* call 0x10165f01 */
            ii(0x100d_c1ec, 3);  add(esp, 0xc);                        /* add esp, 0xc */
        l_0x100d_c1ef:
            ii(0x100d_c1ef, 6);  lea(edx, memd[ss, ebp - 288]);        /* lea edx, [ebp-0x120] */
            ii(0x100d_c1f5, 6);  lea(eax, memd[ss, ebp - 228]);        /* lea eax, [ebp-0xe4] */
            ii(0x100d_c1fb, 5);  call(Definitions.sys_strcat, 0x8_9d31);/* call 0x10165f31 */
        l_0x100d_c200:
            ii(0x100d_c200, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x100d_c205, 5);  call(/* sys */ 0x1016_a24c, 0x8_e042);/* call 0x1016a24c */
            ii(0x100d_c20a, 5);  call(0x100d_531c, -0x6ef3);           /* call 0x100d531c */
            ii(0x100d_c20f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100d_c214, 1);  push(eax);                            /* push eax */
            ii(0x100d_c215, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_c217, 1);  push(eax);                            /* push eax */
            ii(0x100d_c218, 5);  push(0xa2);                           /* push 0xa2 */
            ii(0x100d_c21d, 5);  mov(eax, 0x20);                       /* mov eax, 0x20 */
            ii(0x100d_c222, 1);  push(eax);                            /* push eax */
            ii(0x100d_c223, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_c226, 3);  sub(eax, 0x20);                       /* sub eax, 0x20 */
            ii(0x100d_c229, 1);  cwde();                               /* cwde */
            ii(0x100d_c22a, 1);  push(eax);                            /* push eax */
            ii(0x100d_c22b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_c22e, 3);  shl(eax, 5);                          /* shl eax, 0x5 */
            ii(0x100d_c231, 1);  cwde();                               /* cwde */
            ii(0x100d_c232, 1);  push(eax);                            /* push eax */
            ii(0x100d_c233, 5);  mov(ecx, 0x20);                       /* mov ecx, 0x20 */
            ii(0x100d_c238, 6);  lea(ebx, memd[ss, ebp - 228]);        /* lea ebx, [ebp-0xe4] */
            ii(0x100d_c23e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c241, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x100d_c244, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_c247, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c24a, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_c24d, 5);  call(0x100e_9ae5, 0xd893);            /* call 0x100e9ae5 */
            ii(0x100d_c252, 5);  jmp(0x100d_bfce, -0x289); goto l_0x100d_bfce;/* jmp 0x100dbfce */
        l_0x100d_c257:
            ii(0x100d_c257, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c25a, 4);  mov(dx, memw[ds, eax + 38]);          /* mov dx, [eax+0x26] */
            ii(0x100d_c25e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c261, 4);  cmp(dx, memw[ds, eax + 36]);          /* cmp dx, [eax+0x24] */
            ii(0x100d_c265, 2);  if(jl(0x100d_c288, 0x21)) goto l_0x100d_c288;/* jl 0x100dc288 */
            ii(0x100d_c267, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c26a, 3);  mov(edx, memd[ds, eax + 34]);         /* mov edx, [eax+0x22] */
            ii(0x100d_c26d, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_c270, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c273, 3);  mov(eax, memd[ds, eax + 38]);         /* mov eax, [eax+0x26] */
            ii(0x100d_c276, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_c279, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_c27b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c27e, 3);  mov(eax, memd[ds, eax + 36]);         /* mov eax, [eax+0x24] */
            ii(0x100d_c281, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_c284, 2);  cmp(eax, edx);                        /* cmp eax, edx */
            ii(0x100d_c286, 2);  if(jl(0x100d_c28d, 5)) goto l_0x100d_c28d;/* jl 0x100dc28d */
        l_0x100d_c288:
            ii(0x100d_c288, 5);  jmp(0x100d_c354, 0xc7); goto l_0x100d_c354;/* jmp 0x100dc354 */
        l_0x100d_c28d:
            ii(0x100d_c28d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c290, 3);  mov(edx, memd[ds, eax + 36]);         /* mov edx, [eax+0x24] */
            ii(0x100d_c293, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_c296, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c299, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_c29c, 5);  call(0x1008_b228, -0x5_1079);         /* call 0x1008b228 */
            ii(0x100d_c2a1, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100d_c2a4, 3);  imul(eax, eax, 0x33);                 /* imul eax, eax, 0x33 */
            ii(0x100d_c2a7, 5);  mov(edx, 0x101c_81c0);                /* mov edx, 0x101c81c0 */
            ii(0x100d_c2ac, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_c2ae, 6);  mov(memd[ss, ebp - 292], edx);        /* mov [ebp-0x124], edx */
            ii(0x100d_c2b4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c2b7, 4);  mov(ax, memw[ds, eax + 38]);          /* mov ax, [eax+0x26] */
            ii(0x100d_c2bb, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c2be, 4);  sub(ax, memw[ds, edx + 36]);          /* sub ax, [edx+0x24] */
            ii(0x100d_c2c2, 3);  shl(eax, 5);                          /* shl eax, 0x5 */
            ii(0x100d_c2c5, 6);  mov(memd[ss, ebp - 296], eax);        /* mov [ebp-0x128], eax */
            ii(0x100d_c2cb, 10);  mov(memd[ss, ebp - 300], 1);         /* mov dword [ebp-0x12c], 0x1 */
            ii(0x100d_c2d5, 6);  push(memd[ss, ebp - 300]);            /* push dword [ebp-0x12c] */
            ii(0x100d_c2db, 6);  mov(eax, memd[ss, ebp - 292]);        /* mov eax, [ebp-0x124] */
            ii(0x100d_c2e1, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100d_c2e3, 3);  and(eax, 0x10);                       /* and eax, 0x10 */
            ii(0x100d_c2e6, 6);  mov(memd[ss, ebp - 304], eax);        /* mov [ebp-0x130], eax */
            ii(0x100d_c2ec, 6);  push(memd[ss, ebp - 304]);            /* push dword [ebp-0x130] */
            ii(0x100d_c2f2, 6);  mov(eax, memd[ss, ebp - 292]);        /* mov eax, [ebp-0x124] */
            ii(0x100d_c2f8, 3);  test(memb[ds, eax], 0x10);            /* test byte [eax], 0x10 */
            ii(0x100d_c2fb, 2);  if(jz(0x100d_c309, 0xc)) goto l_0x100d_c309;/* jz 0x100dc309 */
            ii(0x100d_c2fd, 10);  mov(memd[ss, ebp - 308], 0x4_0000);  /* mov dword [ebp-0x134], 0x40000 */
            ii(0x100d_c307, 2);  jmp(0x100d_c313, 0xa); goto l_0x100d_c313;/* jmp 0x100dc313 */
        l_0x100d_c309:
            ii(0x100d_c309, 10);  mov(memd[ss, ebp - 308], 0x2_0000);  /* mov dword [ebp-0x134], 0x20000 */
        l_0x100d_c313:
            ii(0x100d_c313, 6);  push(memd[ss, ebp - 308]);            /* push dword [ebp-0x134] */
            ii(0x100d_c319, 6);  mov(eax, memd[ss, ebp - 296]);        /* mov eax, [ebp-0x128] */
            ii(0x100d_c31f, 5);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x100d_c324, 1);  cwde();                               /* cwde */
            ii(0x100d_c325, 1);  push(eax);                            /* push eax */
            ii(0x100d_c326, 5);  mov(eax, 0x20);                       /* mov eax, 0x20 */
            ii(0x100d_c32b, 1);  push(eax);                            /* push eax */
            ii(0x100d_c32c, 7);  movsx(eax, memw[ss, ebp - 296]);      /* movsx eax, word [ebp-0x128] */
            ii(0x100d_c333, 1);  push(eax);                            /* push eax */
            ii(0x100d_c334, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_c336, 1);  push(eax);                            /* push eax */
            ii(0x100d_c337, 7);  movsx(ecx, memw[ss, ebp - 296]);      /* movsx ecx, word [ebp-0x128] */
            ii(0x100d_c33e, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_c340, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c343, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x100d_c346, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_c349, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c34c, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x100d_c34f, 5);  call(0x1010_2273, 0x2_5f1f);          /* call 0x10102273 */
        l_0x100d_c354:
            ii(0x100d_c354, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c357, 3);  mov(eax, memd[ds, eax + 34]);         /* mov eax, [eax+0x22] */
            ii(0x100d_c35a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_c35d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_c35f, 2);  if(jle(0x100d_c380, 0x1f)) goto l_0x100d_c380;/* jle 0x100dc380 */
            ii(0x100d_c361, 5);  call(0x100d_51e4, -0x7182);           /* call 0x100d51e4 */
            ii(0x100d_c366, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_c368, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100d_c36a, 5);  call(0x100d_5204, -0x716b);           /* call 0x100d5204 */
            ii(0x100d_c36f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c371, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_c373, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c376, 3);  mov(eax, memd[ds, eax + 56]);         /* mov eax, [eax+0x38] */
            ii(0x100d_c379, 5);  call(0x100c_fa7c, -0xc902);           /* call 0x100cfa7c */
            ii(0x100d_c37e, 2);  jmp(0x100d_c394, 0x14); goto l_0x100d_c394;/* jmp 0x100dc394 */
        l_0x100d_c380:
            ii(0x100d_c380, 5);  call(0x100d_51c4, -0x71c1);           /* call 0x100d51c4 */
            ii(0x100d_c385, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c387, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_c389, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c38c, 3);  mov(eax, memd[ds, eax + 56]);         /* mov eax, [eax+0x38] */
            ii(0x100d_c38f, 5);  call(0x100c_fb06, -0xc88e);           /* call 0x100cfb06 */
        l_0x100d_c394:
            ii(0x100d_c394, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c397, 3);  mov(edx, memd[ds, eax + 34]);         /* mov edx, [eax+0x22] */
            ii(0x100d_c39a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100d_c39d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c3a0, 3);  mov(eax, memd[ds, eax + 38]);         /* mov eax, [eax+0x26] */
            ii(0x100d_c3a3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_c3a6, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_c3a8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c3ab, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100d_c3ae, 5);  call(Definitions.my_2_get_count, -0x5_104b);/* call 0x1008b368 */
            ii(0x100d_c3b3, 1);  cwde();                               /* cwde */
            ii(0x100d_c3b4, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_c3b6, 2);  if(jge(0x100d_c3d7, 0x1f)) goto l_0x100d_c3d7;/* jge 0x100dc3d7 */
            ii(0x100d_c3b8, 5);  call(0x100d_51e4, -0x71d9);           /* call 0x100d51e4 */
            ii(0x100d_c3bd, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_c3bf, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100d_c3c1, 5);  call(0x100d_5204, -0x71c2);           /* call 0x100d5204 */
            ii(0x100d_c3c6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c3c8, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_c3ca, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c3cd, 3);  mov(eax, memd[ds, eax + 60]);         /* mov eax, [eax+0x3c] */
            ii(0x100d_c3d0, 5);  call(0x100c_fa7c, -0xc959);           /* call 0x100cfa7c */
            ii(0x100d_c3d5, 2);  jmp(0x100d_c3eb, 0x14); goto l_0x100d_c3eb;/* jmp 0x100dc3eb */
        l_0x100d_c3d7:
            ii(0x100d_c3d7, 5);  call(0x100d_51c4, -0x7218);           /* call 0x100d51c4 */
            ii(0x100d_c3dc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c3de, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100d_c3e0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c3e3, 3);  mov(eax, memd[ds, eax + 60]);         /* mov eax, [eax+0x3c] */
            ii(0x100d_c3e6, 5);  call(0x100c_fb06, -0xc8e5);           /* call 0x100cfb06 */
        l_0x100d_c3eb:
            ii(0x100d_c3eb, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_c3ee, 3);  add(edx, 4);                          /* add edx, 0x4 */
            ii(0x100d_c3f1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_c3f4, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100d_c3f7, 5);  call(Definitions.sys_display_draw_1, 0x8_b0ac);/* call 0x101674a8 */
            ii(0x100d_c3fc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_c3fe, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_c3ff, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_c400, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_c401, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_c402, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_c403, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_c404, 1);  ret();                                /* ret */
        }
    }
}
