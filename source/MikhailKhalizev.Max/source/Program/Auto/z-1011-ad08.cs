using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ad08-c6a2146e")]
        public void Method_1011_ad08()
        {
            ii(0x1011_ad08, 5);  push(0x68);                           /* push 0x68 */
            ii(0x1011_ad0d, 5);  call(Definitions.sys_check_available_stack_size, 0x4_b040);/* call 0x10165d52 */
            ii(0x1011_ad12, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_ad13, 1);  push(esi);                            /* push esi */
            ii(0x1011_ad14, 1);  push(edi);                            /* push edi */
            ii(0x1011_ad15, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_ad16, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_ad18, 6);  sub(esp, 0x50);                       /* sub esp, 0x50 */
            ii(0x1011_ad1e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_ad21, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_ad24, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1011_ad27, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_ad29, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_ad2c, 3);  mov(al, memb[ds, edx + 78]);          /* mov al, [edx+0x4e] */
            ii(0x1011_ad2f, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1011_ad32, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad35, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1011_ad38, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_ad3a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ad3d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_ad3f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad42, 3);  mov(al, memb[ds, eax + 100]);         /* mov al, [eax+0x64] */
            ii(0x1011_ad45, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_ad47, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_ad49, 3);  mov(memd[ss, ebp - 56], edx);         /* mov [ebp-0x38], edx */
            ii(0x1011_ad4c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad4f, 4);  cmp(memb[ds, eax + 79], 0);           /* cmp byte [eax+0x4f], 0x0 */
            ii(0x1011_ad53, 2);  if(jz(0x1011_ad61, 0xc)) goto l_0x1011_ad61;/* jz 0x1011ad61 */
            ii(0x1011_ad55, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad58, 3);  mov(al, memb[ds, eax + 79]);          /* mov al, [eax+0x4f] */
            ii(0x1011_ad5b, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_ad5d, 1);  dec(eax);                             /* dec eax */
            ii(0x1011_ad5e, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
        l_0x1011_ad61:
            ii(0x1011_ad61, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad64, 3);  mov(al, memb[ds, eax + 100]);         /* mov al, [eax+0x64] */
            ii(0x1011_ad67, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_ad69, 3);  mov(edx, memd[ss, ebp - 64]);         /* mov edx, [ebp-0x40] */
            ii(0x1011_ad6c, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1011_ad6f, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_ad71, 3);  mov(memd[ss, ebp - 64], edx);         /* mov [ebp-0x40], edx */
            ii(0x1011_ad74, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad77, 5);  call(0x1007_623c, -0xa_4b40);         /* call 0x1007623c */
            ii(0x1011_ad7c, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x1011_ad80, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ad83, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_ad86, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad89, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1011_ad8d, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_ad90, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ad93, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1011_ad97, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_ad9a, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_ad9d, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1011_ada0, 5);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1011_ada5, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_ada8, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_adab, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1011_adae, 5);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1011_adb3, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_adb6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_adb9, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_adbc, 5);  call(0x100b_82bc, -0x6_2b05);         /* call 0x100b82bc */
            ii(0x1011_adc1, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_adc4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_adc7, 4);  mov(ax, memw[ds, eax + 22]);          /* mov ax, [eax+0x16] */
            ii(0x1011_adcb, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1011_adce, 2);  jmp(0x1011_add6, 6); goto l_0x1011_add6;/* jmp 0x1011add6 */
        l_0x1011_add0:
            ii(0x1011_add0, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_add3, 3);  inc(memd[ss, ebp - 48]);              /* inc dword [ebp-0x30] */
        l_0x1011_add6:
            ii(0x1011_add6, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_add9, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1011_addd, 6);  if(jg(0x1011_b0cc, 0x2e9)) goto l_0x1011_b0cc;/* jg 0x1011b0cc */
            ii(0x1011_ade3, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_ade6, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1011_adea, 2);  if(jnz(0x1011_adf8, 0xc)) goto l_0x1011_adf8;/* jnz 0x1011adf8 */
            ii(0x1011_adec, 7);  mov(memd[ss, ebp - 64], 0xffff_ffff); /* mov dword [ebp-0x40], 0xffffffff */
            ii(0x1011_adf3, 5);  jmp(0x1011_ae91, 0x99); goto l_0x1011_ae91;/* jmp 0x1011ae91 */
        l_0x1011_adf8:
            ii(0x1011_adf8, 4);  movsx(edx, memw[ss, ebp - 48]);       /* movsx edx, word [ebp-0x30] */
            ii(0x1011_adfc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_adff, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_ae02, 5);  call(0x100b_827c, -0x6_2b8b);         /* call 0x100b827c */
            ii(0x1011_ae07, 4);  movsx(ax, memb[ds, eax]);             /* movsx ax, byte [eax] */
            ii(0x1011_ae0b, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_ae0e, 4);  movsx(edx, memw[ss, ebp - 48]);       /* movsx edx, word [ebp-0x30] */
            ii(0x1011_ae12, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_ae15, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_ae18, 5);  call(0x100b_827c, -0x6_2ba1);         /* call 0x100b827c */
            ii(0x1011_ae1d, 5);  movsx(ax, memb[ds, eax + 1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x1011_ae22, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_ae25, 4);  movsx(eax, memw[ss, ebp - 64]);       /* movsx eax, word [ebp-0x40] */
            ii(0x1011_ae29, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_ae2b, 2);  if(jge(0x1011_ae33, 6)) goto l_0x1011_ae33;/* jge 0x1011ae33 */
            ii(0x1011_ae2d, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1011_ae30, 3);  add(memd[ss, ebp - 64], eax);         /* add [ebp-0x40], eax */
        l_0x1011_ae33:
            ii(0x1011_ae33, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_ae36, 3);  add(memd[ss, ebp - 28], eax);         /* add [ebp-0x1c], eax */
            ii(0x1011_ae39, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_ae3c, 3);  add(memd[ss, ebp - 24], eax);         /* add [ebp-0x18], eax */
            ii(0x1011_ae3f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_ae41, 1);  push(eax);                            /* push eax */
            ii(0x1011_ae42, 4);  movsx(ecx, memw[ss, ebp - 24]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x1011_ae46, 4);  movsx(ebx, memw[ss, ebp - 28]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1011_ae4a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ae4d, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1011_ae50, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_ae52, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_ae55, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ae58, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1011_ae5b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ae5e, 5);  call(0x1007_02b9, -0xa_abaa);         /* call 0x100702b9 */
            ii(0x1011_ae63, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1011_ae66, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_ae6a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_ae6c, 2);  if(jz(0x1011_ae76, 8)) goto l_0x1011_ae76;/* jz 0x1011ae76 */
            ii(0x1011_ae6e, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_ae72, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_ae74, 2);  if(jnz(0x1011_ae78, 2)) goto l_0x1011_ae78;/* jnz 0x1011ae78 */
        l_0x1011_ae76:
            ii(0x1011_ae76, 2);  jmp(0x1011_ae8b, 0x13); goto l_0x1011_ae8b;/* jmp 0x1011ae8b */
        l_0x1011_ae78:
            ii(0x1011_ae78, 4);  movsx(edx, memw[ss, ebp - 60]);       /* movsx edx, word [ebp-0x3c] */
            ii(0x1011_ae7c, 3);  lea(edx, memd[ds, edx + edx * 2]);    /* lea edx, [edx+edx*2] */
            ii(0x1011_ae7f, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_ae81, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_ae84, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1011_ae86, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1011_ae88, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
        l_0x1011_ae8b:
            ii(0x1011_ae8b, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1011_ae8e, 3);  sub(memd[ss, ebp - 64], eax);         /* sub [ebp-0x40], eax */
        l_0x1011_ae91:
            ii(0x1011_ae91, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1011_ae95, 6);  cmp(eax, memd[ds, 0x101c_38f4]);      /* cmp eax, [0x101c38f4] */
            ii(0x1011_ae9b, 2);  if(jge(0x1011_aea9, 0xc)) goto l_0x1011_aea9;/* jge 0x1011aea9 */
            ii(0x1011_ae9d, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1011_aea1, 6);  cmp(eax, memd[ds, 0x101c_38ec]);      /* cmp eax, [0x101c38ec] */
            ii(0x1011_aea7, 2);  if(jg(0x1011_aeab, 2)) goto l_0x1011_aeab;/* jg 0x1011aeab */
        l_0x1011_aea9:
            ii(0x1011_aea9, 2);  jmp(0x1011_aeb7, 0xc); goto l_0x1011_aeb7;/* jmp 0x1011aeb7 */
        l_0x1011_aeab:
            ii(0x1011_aeab, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_aeaf, 6);  cmp(eax, memd[ds, 0x101c_38f8]);      /* cmp eax, [0x101c38f8] */
            ii(0x1011_aeb5, 2);  if(jl(0x1011_aeb9, 2)) goto l_0x1011_aeb9;/* jl 0x1011aeb9 */
        l_0x1011_aeb7:
            ii(0x1011_aeb7, 2);  jmp(0x1011_aec5, 0xc); goto l_0x1011_aec5;/* jmp 0x1011aec5 */
        l_0x1011_aeb9:
            ii(0x1011_aeb9, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1011_aebd, 6);  cmp(eax, memd[ds, 0x101c_38f0]);      /* cmp eax, [0x101c38f0] */
            ii(0x1011_aec3, 2);  if(jg(0x1011_aec7, 2)) goto l_0x1011_aec7;/* jg 0x1011aec7 */
        l_0x1011_aec5:
            ii(0x1011_aec5, 2);  jmp(0x1011_aed7, 0x10); goto l_0x1011_aed7;/* jmp 0x1011aed7 */
        l_0x1011_aec7:
            ii(0x1011_aec7, 5);  cmp(memw[ss, ebp - 36], 0);           /* cmp word [ebp-0x24], 0x0 */
            ii(0x1011_aecc, 2);  if(jnz(0x1011_aed5, 7)) goto l_0x1011_aed5;/* jnz 0x1011aed5 */
            ii(0x1011_aece, 5);  cmp(memw[ss, ebp - 32], 0);           /* cmp word [ebp-0x20], 0x0 */
            ii(0x1011_aed3, 2);  if(jz(0x1011_aed7, 2)) goto l_0x1011_aed7;/* jz 0x1011aed7 */
        l_0x1011_aed5:
            ii(0x1011_aed5, 2);  jmp(0x1011_aedc, 5); goto l_0x1011_aedc;/* jmp 0x1011aedc */
        l_0x1011_aed7:
            ii(0x1011_aed7, 5);  jmp(0x1011_b0af, 0x1d3); goto l_0x1011_b0af;/* jmp 0x1011b0af */
        l_0x1011_aedc:
            ii(0x1011_aedc, 4);  movsx(edx, memw[ss, ebp - 44]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1011_aee0, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1011_aee3, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_aee5, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_aee8, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x1011_aeee, 6);  mov(edx, memd[ds, 0x101c_38fa]);      /* mov edx, [0x101c38fa] */
            ii(0x1011_aef4, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_aef7, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1011_aef9, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1011_aefc, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_af00, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1011_af03, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_af05, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_af08, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x1011_af0e, 6);  mov(edx, memd[ds, 0x101c_38fc]);      /* mov edx, [0x101c38fc] */
            ii(0x1011_af14, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_af17, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1011_af19, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1011_af1c, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_af20, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af22, 2);  if(jnz(0x1011_af2c, 8)) goto l_0x1011_af2c;/* jnz 0x1011af2c */
            ii(0x1011_af24, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_af28, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af2a, 2);  if(jl(0x1011_af2e, 2)) goto l_0x1011_af2e;/* jl 0x1011af2e */
        l_0x1011_af2c:
            ii(0x1011_af2c, 2);  jmp(0x1011_af3a, 0xc); goto l_0x1011_af3a;/* jmp 0x1011af3a */
        l_0x1011_af2e:
            ii(0x1011_af2e, 7);  mov(memd[ss, ebp - 72], 0);           /* mov dword [ebp-0x48], 0x0 */
            ii(0x1011_af35, 5);  jmp(0x1011_afec, 0xb2); goto l_0x1011_afec;/* jmp 0x1011afec */
        l_0x1011_af3a:
            ii(0x1011_af3a, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_af3e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af40, 2);  if(jle(0x1011_af4a, 8)) goto l_0x1011_af4a;/* jle 0x1011af4a */
            ii(0x1011_af42, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_af46, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af48, 2);  if(jl(0x1011_af4c, 2)) goto l_0x1011_af4c;/* jl 0x1011af4c */
        l_0x1011_af4a:
            ii(0x1011_af4a, 2);  jmp(0x1011_af58, 0xc); goto l_0x1011_af58;/* jmp 0x1011af58 */
        l_0x1011_af4c:
            ii(0x1011_af4c, 7);  mov(memd[ss, ebp - 72], 1);           /* mov dword [ebp-0x48], 0x1 */
            ii(0x1011_af53, 5);  jmp(0x1011_afec, 0x94); goto l_0x1011_afec;/* jmp 0x1011afec */
        l_0x1011_af58:
            ii(0x1011_af58, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_af5c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af5e, 2);  if(jle(0x1011_af68, 8)) goto l_0x1011_af68;/* jle 0x1011af68 */
            ii(0x1011_af60, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_af64, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af66, 2);  if(jz(0x1011_af6a, 2)) goto l_0x1011_af6a;/* jz 0x1011af6a */
        l_0x1011_af68:
            ii(0x1011_af68, 2);  jmp(0x1011_af76, 0xc); goto l_0x1011_af76;/* jmp 0x1011af76 */
        l_0x1011_af6a:
            ii(0x1011_af6a, 7);  mov(memd[ss, ebp - 72], 2);           /* mov dword [ebp-0x48], 0x2 */
            ii(0x1011_af71, 5);  jmp(0x1011_afec, 0x76); goto l_0x1011_afec;/* jmp 0x1011afec */
        l_0x1011_af76:
            ii(0x1011_af76, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_af7a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af7c, 2);  if(jle(0x1011_af86, 8)) goto l_0x1011_af86;/* jle 0x1011af86 */
            ii(0x1011_af7e, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_af82, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af84, 2);  if(jg(0x1011_af88, 2)) goto l_0x1011_af88;/* jg 0x1011af88 */
        l_0x1011_af86:
            ii(0x1011_af86, 2);  jmp(0x1011_af94, 0xc); goto l_0x1011_af94;/* jmp 0x1011af94 */
        l_0x1011_af88:
            ii(0x1011_af88, 7);  mov(memd[ss, ebp - 72], 3);           /* mov dword [ebp-0x48], 0x3 */
            ii(0x1011_af8f, 5);  jmp(0x1011_afec, 0x58); goto l_0x1011_afec;/* jmp 0x1011afec */
        l_0x1011_af94:
            ii(0x1011_af94, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_af98, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_af9a, 2);  if(jnz(0x1011_afa4, 8)) goto l_0x1011_afa4;/* jnz 0x1011afa4 */
            ii(0x1011_af9c, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_afa0, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_afa2, 2);  if(jg(0x1011_afa6, 2)) goto l_0x1011_afa6;/* jg 0x1011afa6 */
        l_0x1011_afa4:
            ii(0x1011_afa4, 2);  jmp(0x1011_afaf, 9); goto l_0x1011_afaf;/* jmp 0x1011afaf */
        l_0x1011_afa6:
            ii(0x1011_afa6, 7);  mov(memd[ss, ebp - 72], 4);           /* mov dword [ebp-0x48], 0x4 */
            ii(0x1011_afad, 2);  jmp(0x1011_afec, 0x3d); goto l_0x1011_afec;/* jmp 0x1011afec */
        l_0x1011_afaf:
            ii(0x1011_afaf, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_afb3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_afb5, 2);  if(jge(0x1011_afbf, 8)) goto l_0x1011_afbf;/* jge 0x1011afbf */
            ii(0x1011_afb7, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_afbb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_afbd, 2);  if(jg(0x1011_afc1, 2)) goto l_0x1011_afc1;/* jg 0x1011afc1 */
        l_0x1011_afbf:
            ii(0x1011_afbf, 2);  jmp(0x1011_afca, 9); goto l_0x1011_afca;/* jmp 0x1011afca */
        l_0x1011_afc1:
            ii(0x1011_afc1, 7);  mov(memd[ss, ebp - 72], 5);           /* mov dword [ebp-0x48], 0x5 */
            ii(0x1011_afc8, 2);  jmp(0x1011_afec, 0x22); goto l_0x1011_afec;/* jmp 0x1011afec */
        l_0x1011_afca:
            ii(0x1011_afca, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_afce, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_afd0, 2);  if(jge(0x1011_afda, 8)) goto l_0x1011_afda;/* jge 0x1011afda */
            ii(0x1011_afd2, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_afd6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_afd8, 2);  if(jz(0x1011_afdc, 2)) goto l_0x1011_afdc;/* jz 0x1011afdc */
        l_0x1011_afda:
            ii(0x1011_afda, 2);  jmp(0x1011_afe5, 9); goto l_0x1011_afe5;/* jmp 0x1011afe5 */
        l_0x1011_afdc:
            ii(0x1011_afdc, 7);  mov(memd[ss, ebp - 72], 6);           /* mov dword [ebp-0x48], 0x6 */
            ii(0x1011_afe3, 2);  jmp(0x1011_afec, 7); goto l_0x1011_afec;/* jmp 0x1011afec */
        l_0x1011_afe5:
            ii(0x1011_afe5, 7);  mov(memd[ss, ebp - 72], 7);           /* mov dword [ebp-0x48], 0x7 */
        l_0x1011_afec:
            ii(0x1011_afec, 4);  movsx(eax, memw[ss, ebp - 64]);       /* movsx eax, word [ebp-0x40] */
            ii(0x1011_aff0, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_aff2, 2);  if(jl(0x1011_affa, 6)) goto l_0x1011_affa;/* jl 0x1011affa */
            ii(0x1011_aff4, 4);  mov(memb[ss, ebp - 80], 3);           /* mov byte [ebp-0x50], 0x3 */
            ii(0x1011_aff8, 2);  jmp(0x1011_affe, 4); goto l_0x1011_affe;/* jmp 0x1011affe */
        l_0x1011_affa:
            ii(0x1011_affa, 4);  mov(memb[ss, ebp - 80], 2);           /* mov byte [ebp-0x50], 0x2 */
        l_0x1011_affe:
            ii(0x1011_affe, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_b000, 3);  mov(al, memb[ss, ebp - 80]);          /* mov al, [ebp-0x50] */
            ii(0x1011_b003, 1);  cwde();                               /* cwde */
            ii(0x1011_b004, 1);  push(eax);                            /* push eax */
            ii(0x1011_b005, 4);  movsx(ecx, memw[ss, ebp - 76]);       /* movsx ecx, word [ebp-0x4c] */
            ii(0x1011_b009, 4);  movsx(ebx, memw[ss, ebp - 68]);       /* movsx ebx, word [ebp-0x44] */
            ii(0x1011_b00d, 4);  movsx(edx, memw[ss, ebp - 72]);       /* movsx edx, word [ebp-0x48] */
            ii(0x1011_b011, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b014, 5);  call(0x1011_94ea, -0x1b2f);           /* call 0x101194ea */
            ii(0x1011_b019, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1011_b01c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_b01f, 4);  cmp(ax, memw[ds, edx + 22]);          /* cmp ax, [edx+0x16] */
            ii(0x1011_b023, 2);  if(jle(0x1011_b02e, 9)) goto l_0x1011_b02e;/* jle 0x1011b02e */
            ii(0x1011_b025, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b028, 4);  cmp(memb[ds, eax + 80], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x1011_b02c, 2);  if(jnz(0x1011_b030, 2)) goto l_0x1011_b030;/* jnz 0x1011b030 */
        l_0x1011_b02e:
            ii(0x1011_b02e, 2);  jmp(0x1011_b038, 8); goto l_0x1011_b038;/* jmp 0x1011b038 */
        l_0x1011_b030:
            ii(0x1011_b030, 4);  movsx(eax, memw[ss, ebp - 56]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1011_b034, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_b036, 2);  if(jge(0x1011_b03a, 2)) goto l_0x1011_b03a;/* jge 0x1011b03a */
        l_0x1011_b038:
            ii(0x1011_b038, 2);  jmp(0x1011_b0af, 0x75); goto l_0x1011_b0af;/* jmp 0x1011b0af */
        l_0x1011_b03a:
            ii(0x1011_b03a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b03d, 5);  call(0x1007_623c, -0xa_4e06);         /* call 0x1007623c */
            ii(0x1011_b042, 4);  cmp(memb[ds, eax + 22], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x1011_b046, 2);  if(jz(0x1011_b055, 0xd)) goto l_0x1011_b055;/* jz 0x1011b055 */
            ii(0x1011_b048, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_b04a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_b04d, 3);  mov(al, memb[ds, edx + 80]);          /* mov al, [edx+0x50] */
            ii(0x1011_b050, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_b053, 2);  jmp(0x1011_b09b, 0x46); goto l_0x1011_b09b;/* jmp 0x1011b09b */
        l_0x1011_b055:
            ii(0x1011_b055, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b058, 5);  call(0x1007_623c, -0xa_4e21);         /* call 0x1007623c */
            ii(0x1011_b05d, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1011_b060, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_b063, 4);  movsx(eax, memw[ss, ebp - 56]);       /* movsx eax, word [ebp-0x38] */
            ii(0x1011_b067, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1011_b06a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b06d, 5);  call(0x1007_623c, -0xa_4e36);         /* call 0x1007623c */
            ii(0x1011_b072, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1011_b075, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_b078, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_b07b, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1011_b07d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_b07f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_b082, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1011_b084, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_b087, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_b08a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_b08c, 3);  mov(dl, memb[ds, eax + 80]);          /* mov dl, [eax+0x50] */
            ii(0x1011_b08f, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1011_b093, 5);  call(Definitions.my_min, -0x9_1914);  /* call 0x10089784 */
            ii(0x1011_b098, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x1011_b09b:
            ii(0x1011_b09b, 4);  movsx(ecx, memw[ss, ebp - 20]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x1011_b09f, 4);  movsx(ebx, memw[ss, ebp - 76]);       /* movsx ebx, word [ebp-0x4c] */
            ii(0x1011_b0a3, 4);  movsx(edx, memw[ss, ebp - 68]);       /* movsx edx, word [ebp-0x44] */
            ii(0x1011_b0a7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_b0aa, 5);  call(0x1011_9737, -0x1978);           /* call 0x10119737 */
        l_0x1011_b0af:
            ii(0x1011_b0af, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1011_b0b2, 3);  sub(memd[ss, ebp - 56], eax);         /* sub [ebp-0x38], eax */
            ii(0x1011_b0b5, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_b0b8, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1011_b0bb, 3);  add(memd[ss, ebp - 44], eax);         /* add [ebp-0x2c], eax */
            ii(0x1011_b0be, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_b0c1, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1011_b0c4, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
            ii(0x1011_b0c7, 5);  jmp(0x1011_add0, -0x2fc); goto l_0x1011_add0;/* jmp 0x1011add0 */
        l_0x1011_b0cc:
            ii(0x1011_b0cc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_b0ce, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_b0cf, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_b0d0, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_b0d1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_b0d2, 1);  ret();                                /* ret */
        }
    }
}
