using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_cca5-2e4f4c02")]
        public void Method_1010_cca5()
        {
            ii(0x1010_cca5, 5);  push(0x6c);                           /* push 0x6c */
            ii(0x1010_ccaa, 5);  call(Definitions.sys_check_available_stack_size, 0x5_90a3);/* call 0x10165d52 */
            ii(0x1010_ccaf, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_ccb0, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_ccb1, 1);  push(edx);                            /* push edx */
            ii(0x1010_ccb2, 1);  push(esi);                            /* push esi */
            ii(0x1010_ccb3, 1);  push(edi);                            /* push edi */
            ii(0x1010_ccb4, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_ccb5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_ccb7, 6);  sub(esp, 0x44);                       /* sub esp, 0x44 */
            ii(0x1010_ccbd, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_ccc0, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1010_ccc5, 5);  call(/* sys */ 0x1016_a24c, 0x5_d582);/* call 0x1016a24c */
            ii(0x1010_ccca, 5);  call(0x1011_5318, 0x8649);            /* call 0x10115318 */
            ii(0x1010_cccf, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_ccd4, 1);  push(eax);                            /* push eax */
            ii(0x1010_ccd5, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_ccda, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1010_ccdf, 5);  mov(edx, 0x101b_97f4);                /* mov edx, 0x101b97f4 */
            ii(0x1010_cce4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cce7, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_cce9, 5);  call(0x1010_8a05, -0x42e9);           /* call 0x10108a05 */
            ii(0x1010_ccee, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_ccf1, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x1010_ccf5, 6);  if(jnz(0x1010_cd7e, 0x83)) goto l_0x1010_cd7e;/* jnz 0x1010cd7e */
            ii(0x1010_ccfb, 7);  mov(memd[ss, ebp - 40], 0x101b_9808); /* mov dword [ebp-0x28], 0x101b9808 */
            ii(0x1010_cd02, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x1010_cd07, 5);  call(Definitions.sys_new, 0x5_90f4);  /* call 0x10165e00 */
            ii(0x1010_cd0c, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_cd0f, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_cd12, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1010_cd15, 4);  cmp(memd[ss, ebp - 48], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1010_cd19, 2);  if(jz(0x1010_cd5f, 0x44)) goto l_0x1010_cd5f;/* jz 0x1010cd5f */
            ii(0x1010_cd1b, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_cd1e, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x1010_cd22, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1010_cd25, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x1010_cd29, 1);  inc(eax);                             /* inc eax */
            ii(0x1010_cd2a, 1);  cwde();                               /* cwde */
            ii(0x1010_cd2b, 1);  push(eax);                            /* push eax */
            ii(0x1010_cd2c, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_cd2f, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1010_cd33, 3);  mov(edx, memd[ss, ebp - 40]);         /* mov edx, [ebp-0x28] */
            ii(0x1010_cd36, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x1010_cd39, 1);  inc(eax);                             /* inc eax */
            ii(0x1010_cd3a, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1010_cd3d, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_cd40, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1010_cd43, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1010_cd46, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_cd49, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1010_cd4c, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_cd4f, 5);  call(0x100d_7bdc, -0x3_5178);         /* call 0x100d7bdc */
            ii(0x1010_cd54, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1010_cd57, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_cd5a, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1010_cd5d, 2);  jmp(0x1010_cd65, 6); goto l_0x1010_cd65;/* jmp 0x1010cd65 */
        l_0x1010_cd5f:
            ii(0x1010_cd5f, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_cd62, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
        l_0x1010_cd65:
            ii(0x1010_cd65, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1010_cd68, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_cd6b, 3);  mov(memd[ds, edx + 20], eax);         /* mov [edx+0x14], eax */
            ii(0x1010_cd6e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cd71, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_cd73, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cd76, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1010_cd79, 5);  call(0x100d_7d74, -0x3_500a);         /* call 0x100d7d74 */
        l_0x1010_cd7e:
            ii(0x1010_cd7e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cd81, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_cd83, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cd86, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1010_cd89, 5);  call(0x100d_7f6c, -0x3_4e22);         /* call 0x100d7f6c */
            ii(0x1010_cd8e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cd91, 3);  mov(eax, memd[ds, eax + 10]);         /* mov eax, [eax+0xa] */
            ii(0x1010_cd94, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_cd97, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_cd9a, 6);  mov(eax, memd[ds, eax + 0x101b_9794]);/* mov eax, [eax+0x101b9794] */
            ii(0x1010_cda0, 5);  mov(memd[ds, 0x101b_9818], eax);      /* mov [0x101b9818], eax */
            ii(0x1010_cda5, 5);  call(0x1011_5318, 0x856e);            /* call 0x10115318 */
            ii(0x1010_cdaa, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_cdaf, 1);  push(eax);                            /* push eax */
            ii(0x1010_cdb0, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_cdb5, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1010_cdba, 5);  mov(edx, 0x101b_9808);                /* mov edx, 0x101b9808 */
            ii(0x1010_cdbf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cdc2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_cdc4, 5);  call(0x1010_8a05, -0x43c4);           /* call 0x10108a05 */
            ii(0x1010_cdc9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cdcc, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_cdce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cdd1, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x1010_cdd4, 5);  call(0x100d_7f6c, -0x3_4e6d);         /* call 0x100d7f6c */
            ii(0x1010_cdd9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cddc, 3);  mov(eax, memd[ds, eax + 10]);         /* mov eax, [eax+0xa] */
            ii(0x1010_cddf, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_cde2, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_cde5, 6);  mov(eax, memd[ds, eax + 0x101b_9734]);/* mov eax, [eax+0x101b9734] */
            ii(0x1010_cdeb, 5);  mov(memd[ds, 0x101b_982c], eax);      /* mov [0x101b982c], eax */
            ii(0x1010_cdf0, 5);  call(0x1011_5318, 0x8523);            /* call 0x10115318 */
            ii(0x1010_cdf5, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_cdfa, 1);  push(eax);                            /* push eax */
            ii(0x1010_cdfb, 5);  call(0x1011_5338, 0x8538);            /* call 0x10115338 */
            ii(0x1010_ce00, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1010_ce02, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x1010_ce04, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1010_ce09, 5);  mov(edx, 0x101b_981c);                /* mov edx, 0x101b981c */
            ii(0x1010_ce0e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_ce11, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_ce13, 5);  call(0x1010_8a05, -0x4413);           /* call 0x10108a05 */
            ii(0x1010_ce18, 7);  mov(memd[ss, ebp - 24], 0xc);         /* mov dword [ebp-0x18], 0xc */
        l_0x1010_ce1f:
            ii(0x1010_ce1f, 3);  dec(memd[ss, ebp - 24]);              /* dec dword [ebp-0x18] */
            ii(0x1010_ce22, 5);  cmp(memw[ss, ebp - 24], -1 /* 0xff */);/* cmp word [ebp-0x18], 0xffff */
            ii(0x1010_ce27, 2);  if(jz(0x1010_ce4f, 0x26)) goto l_0x1010_ce4f;/* jz 0x1010ce4f */
            ii(0x1010_ce29, 5);  call(0x100d_51e4, -0x3_7c4a);         /* call 0x100d51e4 */
            ii(0x1010_ce2e, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_ce30, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1010_ce32, 5);  call(0x100d_5204, -0x3_7c33);         /* call 0x100d5204 */
            ii(0x1010_ce37, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_ce39, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1010_ce3b, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ce3f, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ce42, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_ce45, 3);  mov(eax, memd[ds, eax + 32]);         /* mov eax, [eax+0x20] */
            ii(0x1010_ce48, 5);  call(0x100c_fa7c, -0x3_d3d1);         /* call 0x100cfa7c */
            ii(0x1010_ce4d, 2);  jmp(0x1010_ce1f, -0x30); goto l_0x1010_ce1f;/* jmp 0x1010ce1f */
        l_0x1010_ce4f:
            ii(0x1010_ce4f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_ce52, 4);  cmp(memd[ds, eax + 24], 0);           /* cmp dword [eax+0x18], 0x0 */
            ii(0x1010_ce56, 2);  if(jz(0x1010_ce9c, 0x44)) goto l_0x1010_ce9c;/* jz 0x1010ce9c */
            ii(0x1010_ce58, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_ce5b, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_ce5d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_ce60, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1010_ce63, 5);  call(0x100d_7f6c, -0x3_4efc);         /* call 0x100d7f6c */
            ii(0x1010_ce68, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_ce6b, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1010_ce6e, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1010_ce71, 4);  cmp(memd[ss, ebp - 60], 0);           /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1010_ce75, 2);  if(jz(0x1010_ce8b, 0x14)) goto l_0x1010_ce8b;/* jz 0x1010ce8b */
            ii(0x1010_ce77, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_ce79, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1010_ce7c, 5);  call(Definitions.my_dtor_d3, -0x3_514e);/* call 0x100d7d33 */
            ii(0x1010_ce81, 5);  call(Definitions.sys_delete, 0x5_90de);/* call 0x10165f64 */
            ii(0x1010_ce86, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1010_ce89, 2);  jmp(0x1010_ce92, 7); goto l_0x1010_ce92;/* jmp 0x1010ce92 */
        l_0x1010_ce8b:
            ii(0x1010_ce8b, 7);  mov(memd[ss, ebp - 64], 0);           /* mov dword [ebp-0x40], 0x0 */
        l_0x1010_ce92:
            ii(0x1010_ce92, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_ce95, 7);  mov(memd[ds, eax + 24], 0);           /* mov dword [eax+0x18], 0x0 */
        l_0x1010_ce9c:
            ii(0x1010_ce9c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_ce9f, 3);  mov(edx, memd[ds, edx + 10]);         /* mov edx, [edx+0xa] */
            ii(0x1010_cea2, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_cea5, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x1010_ceaa, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1010_ceac, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1010_ceaf, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1010_ceb1, 3);  mov(memd[ss, ebp - 24], edx);         /* mov [ebp-0x18], edx */
            ii(0x1010_ceb4, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ceb8, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1010_cebb, 7);  mov(ax, memw[ds, eax + 0x101b_9830]); /* mov ax, [eax+0x101b9830] */
            ii(0x1010_cec2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_cec5, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_cec9, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1010_cecc, 7);  mov(ax, memw[ds, eax + 0x101b_9832]); /* mov ax, [eax+0x101b9832] */
            ii(0x1010_ced3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_ced6, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ceda, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1010_cedd, 7);  mov(ax, memw[ds, eax + 0x101b_9834]); /* mov ax, [eax+0x101b9834] */
            ii(0x1010_cee4, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_cee7, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_ceeb, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1010_ceee, 7);  mov(ax, memw[ds, eax + 0x101b_9836]); /* mov ax, [eax+0x101b9836] */
            ii(0x1010_cef5, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_cef8, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x1010_cefd, 5);  call(Definitions.sys_new, 0x5_8efe);  /* call 0x10165e00 */
            ii(0x1010_cf02, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_cf05, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_cf08, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_cf0b, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_cf0f, 2);  if(jz(0x1010_cf3f, 0x2e)) goto l_0x1010_cf3f;/* jz 0x1010cf3f */
            ii(0x1010_cf11, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_cf14, 3);  sub(eax, memd[ss, ebp - 12]);         /* sub eax, [ebp-0xc] */
            ii(0x1010_cf17, 1);  inc(eax);                             /* inc eax */
            ii(0x1010_cf18, 1);  cwde();                               /* cwde */
            ii(0x1010_cf19, 1);  push(eax);                            /* push eax */
            ii(0x1010_cf1a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_cf1d, 3);  sub(eax, memd[ss, ebp - 8]);          /* sub eax, [ebp-0x8] */
            ii(0x1010_cf20, 1);  inc(eax);                             /* inc eax */
            ii(0x1010_cf21, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1010_cf24, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1010_cf28, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_cf2c, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_cf2f, 5);  call(0x100d_7bdc, -0x3_5358);         /* call 0x100d7bdc */
            ii(0x1010_cf34, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_cf37, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_cf3a, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1010_cf3d, 2);  jmp(0x1010_cf45, 6); goto l_0x1010_cf45;/* jmp 0x1010cf45 */
        l_0x1010_cf3f:
            ii(0x1010_cf3f, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_cf42, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
        l_0x1010_cf45:
            ii(0x1010_cf45, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1010_cf48, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_cf4b, 3);  mov(memd[ds, edx + 24], eax);         /* mov [edx+0x18], eax */
            ii(0x1010_cf4e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cf51, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_cf53, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cf56, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1010_cf59, 5);  call(0x100d_7d74, -0x3_51ea);         /* call 0x100d7d74 */
            ii(0x1010_cf5e, 2);  push(1);                              /* push 0x1 */
            ii(0x1010_cf60, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_cf64, 1);  push(eax);                            /* push eax */
            ii(0x1010_cf65, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_cf69, 1);  push(eax);                            /* push eax */
            ii(0x1010_cf6a, 4);  movsx(ecx, memw[ss, ebp - 12]);       /* movsx ecx, word [ebp-0xc] */
            ii(0x1010_cf6e, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_cf72, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cf75, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_cf77, 3);  mov(edx, memd[ds, eax + 14]);         /* mov edx, [eax+0xe] */
            ii(0x1010_cf7a, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_cf7d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cf80, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_cf82, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1010_cf85, 5);  call(/* sys */ 0x1016_a68c, 0x5_d702);/* call 0x1016a68c */
            ii(0x1010_cf8a, 2);  push(1);                              /* push 0x1 */
            ii(0x1010_cf8c, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_cf90, 1);  dec(eax);                             /* dec eax */
            ii(0x1010_cf91, 1);  push(eax);                            /* push eax */
            ii(0x1010_cf92, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1010_cf96, 1);  dec(eax);                             /* dec eax */
            ii(0x1010_cf97, 1);  push(eax);                            /* push eax */
            ii(0x1010_cf98, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1010_cf9c, 3);  lea(ecx, memd[ds, eax + 1]);          /* lea ecx, [eax+0x1] */
            ii(0x1010_cf9f, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_cfa3, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1010_cfa4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cfa7, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_cfa9, 3);  mov(edx, memd[ds, eax + 14]);         /* mov edx, [eax+0xe] */
            ii(0x1010_cfac, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_cfaf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cfb2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_cfb4, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1010_cfb7, 5);  call(/* sys */ 0x1016_a68c, 0x5_d6d0);/* call 0x1016a68c */
            ii(0x1010_cfbc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_cfbf, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_cfc1, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_cfc4, 5);  call(Definitions.sys_display_draw_0, 0x5_a4bb);/* call 0x10167484 */
            ii(0x1010_cfc9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_cfcb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_cfcc, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_cfcd, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_cfce, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_cfcf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_cfd0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_cfd1, 1);  ret();                                /* ret */
        }
    }
}
