using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_c7dd-1e4c4782")]
        public void Method_1010_c7dd()
        {
            ii(0x1010_c7dd, 5);  push(0x384);                          /* push 0x384 */
            ii(0x1010_c7e2, 5);  call(Definitions.sys_check_available_stack_size, 0x5_956b);/* call 0x10165d52 */
            ii(0x1010_c7e7, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_c7e8, 1);  push(esi);                            /* push esi */
            ii(0x1010_c7e9, 1);  push(edi);                            /* push edi */
            ii(0x1010_c7ea, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_c7eb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_c7ed, 6);  sub(esp, 0x370);                      /* sub esp, 0x370 */
            ii(0x1010_c7f3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_c7f6, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1010_c7f9, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1010_c7fc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_c7ff, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_c802, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_c805, 5);  add(eax, 0x76e);                      /* add eax, 0x76e */
            ii(0x1010_c80a, 1);  cwde();                               /* cwde */
            ii(0x1010_c80b, 5);  call(Definitions.my_get_res_data_by_id_malloc, 0x2_79db);/* call 0x101341eb */
            ii(0x1010_c810, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_c813, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_c817, 2);  if(jnz(0x1010_c825, 0xc)) goto l_0x1010_c825;/* jnz 0x1010c825 */
            ii(0x1010_c819, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1010_c820, 5);  jmp(0x1010_ca82, 0x25d); goto l_0x1010_ca82;/* jmp 0x1010ca82 */
        l_0x1010_c825:
            ii(0x1010_c825, 5);  mov(edx, StringDefinitions.Rb11);     /* mov edx, 0x101a4581 */
            ii(0x1010_c82a, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_c82d, 5);  call(Definitions.my_fopen, -0x1_d413);/* call 0x100ef41f */
            ii(0x1010_c832, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_c835, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_c838, 5);  call(Definitions.sys_free, 0x5_e884); /* call 0x1016b0c1 */
            ii(0x1010_c83d, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_c841, 2);  if(jnz(0x1010_c84f, 0xc)) goto l_0x1010_c84f;/* jnz 0x1010c84f */
            ii(0x1010_c843, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1010_c84a, 5);  jmp(0x1010_ca82, 0x233); goto l_0x1010_ca82;/* jmp 0x1010ca82 */
        l_0x1010_c84f:
            ii(0x1010_c84f, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1010_c852, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x1010_c857, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_c85c, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1010_c85f, 5);  call(Definitions.my_fread, -0x1_d3d5);/* call 0x100ef48f */
            ii(0x1010_c864, 3);  cmp(eax, 5);                          /* cmp eax, 0x5 */
            ii(0x1010_c867, 2);  if(jz(0x1010_c873, 0xa)) goto l_0x1010_c873;/* jz 0x1010c873 */
            ii(0x1010_c869, 5);  mov(eax, 7);                          /* mov eax, 0x7 */
            ii(0x1010_c86e, 5);  call(0x100e_f3a0, -0x1_d4d3);         /* call 0x100ef3a0 */
        l_0x1010_c873:
            ii(0x1010_c873, 7);  mov(memd[ss, ebp - 48], 4);           /* mov dword [ebp-0x30], 0x4 */
            ii(0x1010_c87a, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1010_c87d, 3);  mov(ebx, memd[ss, ebp - 48]);         /* mov ebx, [ebp-0x30] */
            ii(0x1010_c880, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_c885, 3);  lea(eax, memd[ss, ebp - 96]);         /* lea eax, [ebp-0x60] */
            ii(0x1010_c888, 5);  call(Definitions.my_fread, -0x1_d3fe);/* call 0x100ef48f */
            ii(0x1010_c88d, 3);  cmp(eax, memd[ss, ebp - 48]);         /* cmp eax, [ebp-0x30] */
            ii(0x1010_c890, 2);  if(jz(0x1010_c89c, 0xa)) goto l_0x1010_c89c;/* jz 0x1010c89c */
            ii(0x1010_c892, 5);  mov(eax, 7);                          /* mov eax, 0x7 */
            ii(0x1010_c897, 5);  call(0x100e_f3a0, -0x1_d4fc);         /* call 0x100ef3a0 */
        l_0x1010_c89c:
            ii(0x1010_c89c, 7);  mov(memd[ss, ebp - 16], 0x70);        /* mov dword [ebp-0x10], 0x70 */
        l_0x1010_c8a3:
            ii(0x1010_c8a3, 3);  dec(memd[ss, ebp - 16]);              /* dec dword [ebp-0x10] */
            ii(0x1010_c8a6, 5);  cmp(memw[ss, ebp - 16], -1 /* 0xff */);/* cmp word [ebp-0x10], 0xffff */
            ii(0x1010_c8ab, 2);  if(jz(0x1010_c8da, 0x2d)) goto l_0x1010_c8da;/* jz 0x1010c8da */
            ii(0x1010_c8ad, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1010_c8b0, 5);  mov(ebx, 0x70);                       /* mov ebx, 0x70 */
            ii(0x1010_c8b5, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_c8ba, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_c8bd, 5);  call(Definitions.my_fread, -0x1_d433);/* call 0x100ef48f */
            ii(0x1010_c8c2, 3);  cmp(eax, 0x70);                       /* cmp eax, 0x70 */
            ii(0x1010_c8c5, 2);  if(jz(0x1010_c8d1, 0xa)) goto l_0x1010_c8d1;/* jz 0x1010c8d1 */
            ii(0x1010_c8c7, 5);  mov(eax, 7);                          /* mov eax, 0x7 */
            ii(0x1010_c8cc, 5);  call(0x100e_f3a0, -0x1_d531);         /* call 0x100ef3a0 */
        l_0x1010_c8d1:
            ii(0x1010_c8d1, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_c8d5, 3);  add(memd[ss, ebp - 24], eax);         /* add [ebp-0x18], eax */
            ii(0x1010_c8d8, 2);  jmp(0x1010_c8a3, -0x37); goto l_0x1010_c8a3;/* jmp 0x1010c8a3 */
        l_0x1010_c8da:
            ii(0x1010_c8da, 4);  movsx(eax, memw[ss, ebp - 94]);       /* movsx eax, word [ebp-0x5e] */
            ii(0x1010_c8de, 4);  movsx(edx, memw[ss, ebp - 96]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1010_c8e2, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1010_c8e5, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1010_c8e7, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1010_c8ea, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1010_c8ef, 3);  mov(edx, memd[ss, ebp - 48]);         /* mov edx, [ebp-0x30] */
            ii(0x1010_c8f2, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_c8f5, 5);  call(Definitions.my_fseek, -0x1_d4a5);/* call 0x100ef455 */
            ii(0x1010_c8fa, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1010_c8fd, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1010_c902, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_c907, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1010_c90a, 5);  call(Definitions.my_fread, -0x1_d480);/* call 0x100ef48f */
            ii(0x1010_c90f, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1010_c912, 2);  if(jz(0x1010_c91e, 0xa)) goto l_0x1010_c91e;/* jz 0x1010c91e */
            ii(0x1010_c914, 5);  mov(eax, 7);                          /* mov eax, 0x7 */
            ii(0x1010_c919, 5);  call(0x100e_f3a0, -0x1_d57e);         /* call 0x100ef3a0 */
        l_0x1010_c91e:
            ii(0x1010_c91e, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c922, 3);  shl(eax, 0xc);                        /* shl eax, 0xc */
            ii(0x1010_c925, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1010_c928, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1010_c92d, 3);  mov(edx, memd[ss, ebp - 48]);         /* mov edx, [ebp-0x30] */
            ii(0x1010_c930, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_c933, 5);  call(Definitions.my_fseek, -0x1_d4e3);/* call 0x100ef455 */
            ii(0x1010_c938, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1010_c93b, 5);  mov(ebx, 0x300);                      /* mov ebx, 0x300 */
            ii(0x1010_c940, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_c945, 6);  lea(eax, memd[ss, ebp - 864]);        /* lea eax, [ebp-0x360] */
            ii(0x1010_c94b, 5);  call(Definitions.my_fread, -0x1_d4c1);/* call 0x100ef48f */
            ii(0x1010_c950, 5);  cmp(eax, 0x300);                      /* cmp eax, 0x300 */
            ii(0x1010_c955, 2);  if(jz(0x1010_c961, 0xa)) goto l_0x1010_c961;/* jz 0x1010c961 */
            ii(0x1010_c957, 5);  mov(eax, 7);                          /* mov eax, 0x7 */
            ii(0x1010_c95c, 5);  call(0x100e_f3a0, -0x1_d5c1);         /* call 0x100ef3a0 */
        l_0x1010_c961:
            ii(0x1010_c961, 7);  mov(memd[ss, ebp - 20], 0x300);       /* mov dword [ebp-0x14], 0x300 */
        l_0x1010_c968:
            ii(0x1010_c968, 3);  dec(memd[ss, ebp - 20]);              /* dec dword [ebp-0x14] */
            ii(0x1010_c96b, 5);  cmp(memw[ss, ebp - 20], -1 /* 0xff */);/* cmp word [ebp-0x14], 0xffff */
            ii(0x1010_c970, 2);  if(jz(0x1010_c980, 0xe)) goto l_0x1010_c980;/* jz 0x1010c980 */
            ii(0x1010_c972, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c976, 8);  shr(memb[ds, eax + ebp - 864], 2);    /* shr byte [eax+ebp-0x360], 0x2 */
            ii(0x1010_c97e, 2);  jmp(0x1010_c968, -0x18); goto l_0x1010_c968;/* jmp 0x1010c968 */
        l_0x1010_c980:
            ii(0x1010_c980, 10);  mov(memd[ds, Definitions.ptr_to_pallete], 0x101b_dec0);/* mov dword [0x101c9464], 0x101bdec0 */
            ii(0x1010_c98a, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_c991, 2);  jmp(0x1010_c997, 4); goto l_0x1010_c997;/* jmp 0x1010c997 */
        l_0x1010_c993:
            ii(0x1010_c993, 4);  add(memd[ss, ebp - 20], 3);           /* add dword [ebp-0x14], 0x3 */
        l_0x1010_c997:
            ii(0x1010_c997, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_c99b, 5);  cmp(eax, 0x300);                      /* cmp eax, 0x300 */
            ii(0x1010_c9a0, 2);  if(jge(0x1010_ca18, 0x76)) goto l_0x1010_ca18;/* jge 0x1010ca18 */
            ii(0x1010_c9a2, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1010_c9a6, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_c9a8, 7);  mov(al, memb[ds, edx + ebp - 864]);   /* mov al, [edx+ebp-0x360] */
            ii(0x1010_c9af, 6);  mov(memd[ss, ebp - 868], eax);        /* mov [ebp-0x364], eax */
            ii(0x1010_c9b5, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1010_c9b9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_c9bb, 7);  mov(al, memb[ds, edx + ebp - 863]);   /* mov al, [edx+ebp-0x35f] */
            ii(0x1010_c9c2, 6);  mov(memd[ss, ebp - 872], eax);        /* mov [ebp-0x368], eax */
            ii(0x1010_c9c8, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1010_c9cc, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_c9ce, 7);  mov(al, memb[ds, edx + ebp - 862]);   /* mov al, [edx+ebp-0x35e] */
            ii(0x1010_c9d5, 6);  mov(memd[ss, ebp - 876], eax);        /* mov [ebp-0x36c], eax */
            ii(0x1010_c9db, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_c9e0, 7);  movsx(ebx, memw[ss, ebp - 876]);      /* movsx ebx, word [ebp-0x36c] */
            ii(0x1010_c9e7, 7);  movsx(edx, memw[ss, ebp - 872]);      /* movsx edx, word [ebp-0x368] */
            ii(0x1010_c9ee, 7);  movsx(eax, memw[ss, ebp - 868]);      /* movsx eax, word [ebp-0x364] */
            ii(0x1010_c9f5, 5);  call(0x1013_3a88, 0x2_708e);          /* call 0x10133a88 */
            ii(0x1010_c9fa, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1010_c9fc, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1010_ca00, 5);  mov(ecx, 3);                          /* mov ecx, 0x3 */
            ii(0x1010_ca05, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1010_ca07, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1010_ca0a, 2);  idiv(ecx);                            /* idiv ecx */
            ii(0x1010_ca0c, 7);  mov(memb[ds, eax + ebp - 864], bl);   /* mov [eax+ebp-0x360], bl */
            ii(0x1010_ca13, 5);  jmp(0x1010_c993, -0x85); goto l_0x1010_c993;/* jmp 0x1010c993 */
        l_0x1010_ca18:
            ii(0x1010_ca18, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_ca1b, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_ca1e, 7);  mov(memd[ss, ebp - 16], 0x70);        /* mov dword [ebp-0x10], 0x70 */
        l_0x1010_ca25:
            ii(0x1010_ca25, 3);  dec(memd[ss, ebp - 16]);              /* dec dword [ebp-0x10] */
            ii(0x1010_ca28, 5);  cmp(memw[ss, ebp - 16], -1 /* 0xff */);/* cmp word [ebp-0x10], 0xffff */
            ii(0x1010_ca2d, 2);  if(jz(0x1010_ca73, 0x44)) goto l_0x1010_ca73;/* jz 0x1010ca73 */
            ii(0x1010_ca2f, 10);  mov(memd[ss, ebp - 880], 0x70);      /* mov dword [ebp-0x370], 0x70 */
        l_0x1010_ca39:
            ii(0x1010_ca39, 6);  dec(memd[ss, ebp - 880]);             /* dec dword [ebp-0x370] */
            ii(0x1010_ca3f, 8);  cmp(memw[ss, ebp - 880], -1 /* 0xff */);/* cmp word [ebp-0x370], 0xffff */
            ii(0x1010_ca47, 2);  if(jz(0x1010_ca67, 0x1e)) goto l_0x1010_ca67;/* jz 0x1010ca67 */
            ii(0x1010_ca49, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_ca4c, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1010_ca4e, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_ca53, 7);  mov(dl, memb[ds, eax + ebp - 864]);   /* mov dl, [eax+ebp-0x360] */
            ii(0x1010_ca5a, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_ca5d, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1010_ca5f, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_ca62, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x1010_ca65, 2);  jmp(0x1010_ca39, -0x2e); goto l_0x1010_ca39;/* jmp 0x1010ca39 */
        l_0x1010_ca67:
            ii(0x1010_ca67, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_ca6b, 3);  sub(eax, 0x70);                       /* sub eax, 0x70 */
            ii(0x1010_ca6e, 3);  add(memd[ss, ebp - 24], eax);         /* add [ebp-0x18], eax */
            ii(0x1010_ca71, 2);  jmp(0x1010_ca25, -0x4e); goto l_0x1010_ca25;/* jmp 0x1010ca25 */
        l_0x1010_ca73:
            ii(0x1010_ca73, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_ca76, 5);  call(Definitions.sys_fclose, 0x6_55ee);/* call 0x10172069 */
            ii(0x1010_ca7b, 7);  mov(memd[ss, ebp - 32], 1);           /* mov dword [ebp-0x20], 0x1 */
        l_0x1010_ca82:
            ii(0x1010_ca82, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_ca85, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_ca87, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_ca88, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_ca89, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_ca8a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_ca8b, 1);  ret();                                /* ret */
        }
    }
}
