using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("daf35f3f-2fc1-4225-aed6-240e3561dcfc")]
        public void Method_1012_bae2()
        {
            ii(0x1012_bae2, 5); pushd(0x70);                            /* push 0x70 */
            ii(0x1012_bae7, 5); calld(Definitions.sys_check_available_stack_size, 0x3_a266); /* call 0x10165d52 */
            ii(0x1012_baec, 1); pushd(esi);                             /* push esi */
            ii(0x1012_baed, 1); pushd(edi);                             /* push edi */
            ii(0x1012_baee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_baef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_baf1, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1012_baf7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_bafa, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_bafd, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1012_bb00, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1012_bb03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_bb06, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1012_bb0a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_bb0d, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1012_bb10, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_bb13, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_bb16, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1012_bb1a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_bb1d, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x1012_bb21, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_bb24, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_bb27, 3); mov(memd_a32[ss, ebp - 0x22], eax);     /* mov [ebp-0x22], eax */
            ii(0x1012_bb2a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_bb2d, 5); calld(/* sys */ 0x1016_7e3c, 0x3_c30a); /* call 0x10167e3c */
            ii(0x1012_bb32, 4); mov(memw_a32[ss, ebp - 0x24], ax);      /* mov [ebp-0x24], ax */
            ii(0x1012_bb36, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1012_bb3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_bb3d, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x1012_bb40, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x1012_bb43, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_bb46, 5); calld(/* sys */ 0x1016_7dd4, 0x3_c289); /* call 0x10167dd4 */
            ii(0x1012_bb4b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_bb4d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_bb50, 2); add(edx, memd_a32[ds, eax]);            /* add edx, [eax] */
            ii(0x1012_bb52, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1012_bb54, 3); mov(memd_a32[ss, ebp - 0x1e], edx);     /* mov [ebp-0x1e], edx */
            ii(0x1012_bb57, 3); lea(edi, ebp - 0x34);                   /* lea edi, [ebp-0x34] */
            ii(0x1012_bb5a, 3); mov(esi, memd_a32[ss, ebp - 0x8]);      /* mov esi, [ebp-0x8] */
            ii(0x1012_bb5d, 1); movsd_a32();                            /* movsd */
            ii(0x1012_bb5e, 1); movsd_a32();                            /* movsd */
            ii(0x1012_bb5f, 1); movsd_a32();                            /* movsd */
            ii(0x1012_bb60, 1); movsd_a32();                            /* movsd */
            ii(0x1012_bb61, 4); cmp(memb_a32[ss, ebp + 0x20], 0);       /* cmp byte [ebp+0x20], 0x0 */
            ii(0x1012_bb65, 2); if(jzd(0x1012_bb86, 0x1f)) goto l_0x1012_bb86; /* jz 0x1012bb86 */
            ii(0x1012_bb67, 2); pushd(0x3c);                            /* push 0x3c */
            ii(0x1012_bb69, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_bb6d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bb6e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_bb72, 1); dec(eax);                               /* dec eax */
            ii(0x1012_bb73, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bb74, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x1012_bb78, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_bb7a, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1012_bb7e, 3); mov(eax, memd_a32[ss, ebp - 0x1e]);     /* mov eax, [ebp-0x1e] */
            ii(0x1012_bb81, 5); calld(/* sys */ 0x1016_a5a0, 0x3_ea1a); /* call 0x1016a5a0 */
        l_0x1012_bb86:
            ii(0x1012_bb86, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_bb8a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_bb8c, 6); if(jzd(0x1012_bd31, 0x19f)) goto l_0x1012_bd31; /* jz 0x1012bd31 */
            ii(0x1012_bb92, 4); movsx(edx, memw_a32[ss, ebp + 0x18]);   /* movsx edx, word [ebp+0x18] */
            ii(0x1012_bb96, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1012_bb9a, 5); calld(Definitions.my_min, -0xa_241b);   /* call 0x10089784 */
            ii(0x1012_bb9f, 3); mov(memd_a32[ss, ebp + 0x14], eax);     /* mov [ebp+0x14], eax */
            ii(0x1012_bba2, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_bba6, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1012_bba9, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x1012_bbad, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_bbaf, 2); if(jgd(0x1012_bbd0, 0x1f)) goto l_0x1012_bbd0; /* jg 0x1012bbd0 */
            ii(0x1012_bbb1, 6); cmp(memw_a32[ss, ebp - 0x4], 0x276);    /* cmp word [ebp-0x4], 0x276 */
            ii(0x1012_bbb7, 2); if(jnzd(0x1012_bbc7, 0xe)) goto l_0x1012_bbc7; /* jnz 0x1012bbc7 */
            ii(0x1012_bbb9, 7); mov(memd_a32[ss, ebp - 0x4], 0x27a);    /* mov dword [ebp-0x4], 0x27a */
            ii(0x1012_bbc0, 7); mov(memd_a32[ss, ebp + 0x10], 0x27b);   /* mov dword [ebp+0x10], 0x27b */
        l_0x1012_bbc7:
            ii(0x1012_bbc7, 7); mov(memd_a32[ss, ebp - 0x38], 0x1);     /* mov dword [ebp-0x38], 0x1 */
            ii(0x1012_bbce, 2); jmpd(0x1012_bc04, 0x34); goto l_0x1012_bc04; /* jmp 0x1012bc04 */
        l_0x1012_bbd0:
            ii(0x1012_bbd0, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_bbd4, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_bbd6, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x1012_bbda, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_bbdc, 2); if(jgd(0x1012_bbfd, 0x1f)) goto l_0x1012_bbfd; /* jg 0x1012bbfd */
            ii(0x1012_bbde, 6); cmp(memw_a32[ss, ebp - 0x4], 0x276);    /* cmp word [ebp-0x4], 0x276 */
            ii(0x1012_bbe4, 2); if(jnzd(0x1012_bbf4, 0xe)) goto l_0x1012_bbf4; /* jnz 0x1012bbf4 */
            ii(0x1012_bbe6, 7); mov(memd_a32[ss, ebp - 0x4], 0x278);    /* mov dword [ebp-0x4], 0x278 */
            ii(0x1012_bbed, 7); mov(memd_a32[ss, ebp + 0x10], 0x279);   /* mov dword [ebp+0x10], 0x279 */
        l_0x1012_bbf4:
            ii(0x1012_bbf4, 7); mov(memd_a32[ss, ebp - 0x38], 0x4);     /* mov dword [ebp-0x38], 0x4 */
            ii(0x1012_bbfb, 2); jmpd(0x1012_bc04, 0x7); goto l_0x1012_bc04; /* jmp 0x1012bc04 */
        l_0x1012_bbfd:
            ii(0x1012_bbfd, 7); mov(memd_a32[ss, ebp - 0x38], 0x2);     /* mov dword [ebp-0x38], 0x2 */
        l_0x1012_bc04:
            ii(0x1012_bc04, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1012_bc09, 5); calld(/* sys */ 0x1016_a24c, 0x3_e63e); /* call 0x1016a24c */
            ii(0x1012_bc0e, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_bc12, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc13, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1012_bc17, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc18, 5); mov(eax, StringDefinitions.II3);        /* mov eax, 0x101a86d7 */
            ii(0x1012_bc1d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc1e, 3); lea(eax, ebp - 0x44);                   /* lea eax, [ebp-0x44] */
            ii(0x1012_bc21, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc22, 5); calld(Definitions.sys_sprintf, 0x3_a2da); /* call 0x10165f01 */
            ii(0x1012_bc27, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_bc2a, 7); mov(memd_a32[ss, ebp - 0x48], 0x19);    /* mov dword [ebp-0x48], 0x19 */
            ii(0x1012_bc31, 6); cmp(memw_a32[ss, ebp - 0x4], 0x280);    /* cmp word [ebp-0x4], 0x280 */
            ii(0x1012_bc37, 2); if(jzd(0x1012_bc41, 0x8)) goto l_0x1012_bc41; /* jz 0x1012bc41 */
            ii(0x1012_bc39, 6); cmp(memw_a32[ss, ebp - 0x4], 0x282);    /* cmp word [ebp-0x4], 0x282 */
            ii(0x1012_bc3f, 2); if(jnzd(0x1012_bc48, 0x7)) goto l_0x1012_bc48; /* jnz 0x1012bc48 */
        l_0x1012_bc41:
            ii(0x1012_bc41, 7); mov(memd_a32[ss, ebp - 0x48], 0x14);    /* mov dword [ebp-0x48], 0x14 */
        l_0x1012_bc48:
            ii(0x1012_bc48, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_bc4c, 4); movsx(edx, memw_a32[ss, ebp + 0x1c]);   /* movsx edx, word [ebp+0x1c] */
            ii(0x1012_bc50, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_bc52, 4); movsx(ebx, memw_a32[ss, ebp + 0x1c]);   /* movsx ebx, word [ebp+0x1c] */
            ii(0x1012_bc56, 1); dec(edx);                               /* dec edx */
            ii(0x1012_bc57, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_bc59, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_bc5c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_bc5e, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1012_bc62, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1012_bc64, 2); if(jled(0x1012_bc7f, 0x19)) goto l_0x1012_bc7f; /* jle 0x1012bc7f */
            ii(0x1012_bc66, 4); movsx(edx, memw_a32[ss, ebp + 0x18]);   /* movsx edx, word [ebp+0x18] */
            ii(0x1012_bc6a, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1012_bc6e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_bc70, 4); movsx(ebx, memw_a32[ss, ebp - 0x48]);   /* movsx ebx, word [ebp-0x48] */
            ii(0x1012_bc74, 1); dec(edx);                               /* dec edx */
            ii(0x1012_bc75, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_bc77, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_bc7a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_bc7c, 3); mov(memd_a32[ss, ebp + 0x1c], eax);     /* mov [ebp+0x1c], eax */
        l_0x1012_bc7f:
            ii(0x1012_bc7f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_bc84, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc85, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_bc8a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc8b, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1012_bc8e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc8f, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_bc93, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc94, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1012_bc99, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc9a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_bc9c, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bc9d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_bc9f, 3); lea(ebx, ebp - 0x44);                   /* lea ebx, [ebp-0x44] */
            ii(0x1012_bca2, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1012_bca6, 3); mov(eax, memd_a32[ss, ebp - 0x1e]);     /* mov eax, [ebp-0x1e] */
            ii(0x1012_bca9, 5); calld(0x100e_9ae5, -0x4_21c9);          /* call 0x100e9ae5 */
            ii(0x1012_bcae, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x1012_bcb2, 4); movsx(eax, memw_a32[ss, ebp + 0x1c]);   /* movsx eax, word [ebp+0x1c] */
            ii(0x1012_bcb6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_bcb8, 4); movsx(ebx, memw_a32[ss, ebp + 0x1c]);   /* movsx ebx, word [ebp+0x1c] */
            ii(0x1012_bcbc, 1); dec(edx);                               /* dec edx */
            ii(0x1012_bcbd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_bcbf, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_bcc2, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_bcc4, 3); mov(memd_a32[ss, ebp + 0x14], eax);     /* mov [ebp+0x14], eax */
            ii(0x1012_bcc7, 4); movsx(edx, memw_a32[ss, ebp + 0x18]);   /* movsx edx, word [ebp+0x18] */
            ii(0x1012_bccb, 4); movsx(eax, memw_a32[ss, ebp + 0x1c]);   /* movsx eax, word [ebp+0x1c] */
            ii(0x1012_bccf, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_bcd1, 4); movsx(ebx, memw_a32[ss, ebp + 0x1c]);   /* movsx ebx, word [ebp+0x1c] */
            ii(0x1012_bcd5, 1); dec(edx);                               /* dec edx */
            ii(0x1012_bcd6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_bcd8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_bcdb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_bcdd, 3); mov(memd_a32[ss, ebp + 0x18], eax);     /* mov [ebp+0x18], eax */
            ii(0x1012_bce0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_bce5, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bce6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_bce8, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bce9, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1012_bcee, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_bcf2, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bcf3, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1012_bcf8, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bcf9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_bcfb, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bcfc, 5); mov(ecx, 0x2d);                         /* mov ecx, 0x2d */
            ii(0x1012_bd01, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1012_bd04, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1012_bd08, 3); mov(eax, memd_a32[ss, ebp - 0x1e]);     /* mov eax, [ebp-0x1e] */
            ii(0x1012_bd0b, 5); calld(0x100e_9ae5, -0x4_222b);          /* call 0x100e9ae5 */
            ii(0x1012_bd10, 4); add(memd_a32[ss, ebp - 0x1e], 0x4b);    /* add dword [ebp-0x1e], 0x4b */
            ii(0x1012_bd14, 4); add(memd_a32[ss, ebp - 0x34], 0x4b);    /* add dword [ebp-0x34], 0x4b */
            ii(0x1012_bd18, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_bd1c, 1); pushd(eax);                             /* push eax */
            ii(0x1012_bd1d, 4); movsx(ecx, memw_a32[ss, ebp + 0x14]);   /* movsx ecx, word [ebp+0x14] */
            ii(0x1012_bd21, 4); movsx(ebx, memw_a32[ss, ebp + 0x10]);   /* movsx ebx, word [ebp+0x10] */
            ii(0x1012_bd25, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_bd29, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1012_bd2c, 5); calld(0x1012_b87d, -0x4b4);             /* call 0x1012b87d */
        l_0x1012_bd31:
            ii(0x1012_bd31, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_bd33, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_bd34, 1); popd(edi);                              /* pop edi */
            ii(0x1012_bd35, 1); popd(esi);                              /* pop esi */
            ii(0x1012_bd36, 3); retd(0x14); return;                     /* ret 0x14 */
        }
    }
}
