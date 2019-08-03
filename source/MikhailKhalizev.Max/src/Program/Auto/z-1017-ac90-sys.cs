using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a19c3655-4063-4829-ac1c-06894401ae35")]
        public void /* sys */ Method_1017_ac90()
        {
            ii(0x1017_ac90, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_ac91, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_ac93, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_ac94, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_ac95, 1); pushd(edx);                             /* push edx */
            ii(0x1017_ac96, 1); pushd(esi);                             /* push esi */
            ii(0x1017_ac97, 3); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1017_ac9a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_ac9c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_ac9e, 2); if(jnzd(0x1017_acaf, 0xf)) goto l_0x1017_acaf; /* jnz 0x1017acaf */
            ii(0x1017_aca0, 2); pushd(0x13);                            /* push 0x13 */
            ii(0x1017_aca2, 5); calld(/* sys */ 0x1019_41db, 0x19534);  /* call 0x101941db */
            ii(0x1017_aca7, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_acaa, 5); jmpd(0x1017_aeef, 0x240); goto l_0x1017_aeef; /* jmp 0x1017aeef */
        l_0x1017_acaf:
            ii(0x1017_acaf, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1017_acb2, 2); sub(al, 0x5);                           /* sub al, 0x5 */
            ii(0x1017_acb4, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x1017_acb7, 3); mov(al, memb_a32[ds, edx + 0x10]);      /* mov al, [edx+0x10] */
            ii(0x1017_acba, 3); mov(memb_a32[ss, ebp - 0x33], al);      /* mov [ebp-0x33], al */
            ii(0x1017_acbd, 3); mov(al, memb_a32[ds, edx + 0x14]);      /* mov al, [edx+0x14] */
            ii(0x1017_acc0, 3); mov(memb_a32[ss, ebp - 0x32], al);      /* mov [ebp-0x32], al */
            ii(0x1017_acc3, 6); mov(al, memb_a32[ds, edx + 0xa4]);      /* mov al, [edx+0xa4] */
            ii(0x1017_acc9, 3); mov(ah, memb_a32[ds, edx + 0x24]);      /* mov ah, [edx+0x24] */
            ii(0x1017_accc, 3); shl(al, 0x7);                           /* shl al, 0x7 */
            ii(0x1017_accf, 3); shl(ah, 0x5);                           /* shl ah, 0x5 */
            ii(0x1017_acd2, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_acd4, 3); mov(al, memb_a32[ds, edx + 0x20]);      /* mov al, [edx+0x20] */
            ii(0x1017_acd7, 2); and(al, 0x1f);                          /* and al, 0x1f */
            ii(0x1017_acd9, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_acdb, 3); mov(memb_a32[ss, ebp - 0x31], ah);      /* mov [ebp-0x31], ah */
            ii(0x1017_acde, 3); mov(al, memb_a32[ds, edx + 0x18]);      /* mov al, [edx+0x18] */
            ii(0x1017_ace1, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x1017_ace4, 3); mov(ah, memb_a32[ds, edx + 0x20]);      /* mov ah, [edx+0x20] */
            ii(0x1017_ace7, 3); mov(al, memb_a32[ds, edx + 0x28]);      /* mov al, [edx+0x28] */
            ii(0x1017_acea, 3); and(ah, 0x20);                          /* and ah, 0x20 */
            ii(0x1017_aced, 3); shl(al, 0x5);                           /* shl al, 0x5 */
            ii(0x1017_acf0, 3); shl(ah, 0x2);                           /* shl ah, 0x2 */
            ii(0x1017_acf3, 2); or(al, ah);                             /* or al, ah */
            ii(0x1017_acf5, 3); mov(ah, memb_a32[ds, edx + 0x1c]);      /* mov ah, [edx+0x1c] */
            ii(0x1017_acf8, 3); and(ah, 0x1f);                          /* and ah, 0x1f */
            ii(0x1017_acfb, 2); or(al, ah);                             /* or al, ah */
            ii(0x1017_acfd, 3); mov(memb_a32[ss, ebp - 0x2f], al);      /* mov [ebp-0x2f], al */
            ii(0x1017_ad00, 3); mov(al, memb_a32[ds, edx + 0x2c]);      /* mov al, [edx+0x2c] */
            ii(0x1017_ad03, 2); sub(al, 0x2);                           /* sub al, 0x2 */
            ii(0x1017_ad05, 3); mov(memb_a32[ss, ebp - 0x2e], al);      /* mov [ebp-0x2e], al */
            ii(0x1017_ad08, 3); mov(eax, memd_a32[ds, edx + 0x38]);     /* mov eax, [edx+0x38] */
            ii(0x1017_ad0b, 3); mov(ecx, memd_a32[ds, edx + 0x30]);     /* mov ecx, [edx+0x30] */
            ii(0x1017_ad0e, 5); and(eax, 0x200);                        /* and eax, 0x200 */
            ii(0x1017_ad13, 6); and(ecx, 0x200);                        /* and ecx, 0x200 */
            ii(0x1017_ad19, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1017_ad1c, 3); shr(ecx, 0x3);                          /* shr ecx, 0x3 */
            ii(0x1017_ad1f, 2); or(ecx, eax);                           /* or ecx, eax */
            ii(0x1017_ad21, 3); mov(eax, memd_a32[ds, edx + 0x2c]);     /* mov eax, [edx+0x2c] */
            ii(0x1017_ad24, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1017_ad27, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_ad29, 6); and(ebx, 0x200);                        /* and ebx, 0x200 */
            ii(0x1017_ad2f, 3); shr(ebx, 0x4);                          /* shr ebx, 0x4 */
            ii(0x1017_ad32, 2); or(ebx, ecx);                           /* or ebx, ecx */
            ii(0x1017_ad34, 3); mov(ecx, memd_a32[ds, edx + 0x44]);     /* mov ecx, [edx+0x44] */
            ii(0x1017_ad37, 6); and(ecx, 0x100);                        /* and ecx, 0x100 */
            ii(0x1017_ad3d, 3); shr(ecx, 0x4);                          /* shr ecx, 0x4 */
            ii(0x1017_ad40, 2); or(ebx, ecx);                           /* or ebx, ecx */
            ii(0x1017_ad42, 3); mov(ecx, memd_a32[ds, edx + 0x34]);     /* mov ecx, [edx+0x34] */
            ii(0x1017_ad45, 6); and(ecx, 0x100);                        /* and ecx, 0x100 */
            ii(0x1017_ad4b, 3); shr(ecx, 0x5);                          /* shr ecx, 0x5 */
            ii(0x1017_ad4e, 2); or(ebx, ecx);                           /* or ebx, ecx */
            ii(0x1017_ad50, 3); mov(ecx, memd_a32[ds, edx + 0x38]);     /* mov ecx, [edx+0x38] */
            ii(0x1017_ad53, 6); and(ecx, 0x100);                        /* and ecx, 0x100 */
            ii(0x1017_ad59, 3); shr(ecx, 0x6);                          /* shr ecx, 0x6 */
            ii(0x1017_ad5c, 2); or(ecx, ebx);                           /* or ecx, ebx */
            ii(0x1017_ad5e, 3); mov(ebx, memd_a32[ds, edx + 0x30]);     /* mov ebx, [edx+0x30] */
            ii(0x1017_ad61, 6); and(ebx, 0x100);                        /* and ebx, 0x100 */
            ii(0x1017_ad67, 5); and(eax, 0x100);                        /* and eax, 0x100 */
            ii(0x1017_ad6c, 3); shr(ebx, 0x7);                          /* shr ebx, 0x7 */
            ii(0x1017_ad6f, 3); shr(eax, 0x8);                          /* shr eax, 0x8 */
            ii(0x1017_ad72, 2); or(ebx, ecx);                           /* or ebx, ecx */
            ii(0x1017_ad74, 2); or(eax, ebx);                           /* or eax, ebx */
            ii(0x1017_ad76, 3); mov(memb_a32[ss, ebp - 0x2d], al);      /* mov [ebp-0x2d], al */
            ii(0x1017_ad79, 3); mov(al, memb_a32[ds, edx + 0x54]);      /* mov al, [edx+0x54] */
            ii(0x1017_ad7c, 3); mov(ah, memb_a32[ds, edx + 0x48]);      /* mov ah, [edx+0x48] */
            ii(0x1017_ad7f, 3); shl(al, 0x5);                           /* shl al, 0x5 */
            ii(0x1017_ad82, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ad84, 3); mov(memb_a32[ss, ebp - 0x2c], ah);      /* mov [ebp-0x2c], ah */
            ii(0x1017_ad87, 3); mov(eax, memd_a32[ds, edx + 0x44]);     /* mov eax, [edx+0x44] */
            ii(0x1017_ad8a, 3); mov(ebx, memd_a32[ds, edx + 0x68]);     /* mov ebx, [edx+0x68] */
            ii(0x1017_ad8d, 5); and(eax, 0x200);                        /* and eax, 0x200 */
            ii(0x1017_ad92, 3); shl(ebx, 0x7);                          /* shl ebx, 0x7 */
            ii(0x1017_ad95, 3); shr(eax, 0x3);                          /* shr eax, 0x3 */
            ii(0x1017_ad98, 2); or(ebx, eax);                           /* or ebx, eax */
            ii(0x1017_ad9a, 3); mov(eax, memd_a32[ds, edx + 0x34]);     /* mov eax, [edx+0x34] */
            ii(0x1017_ad9d, 5); and(eax, 0x200);                        /* and eax, 0x200 */
            ii(0x1017_ada2, 3); shr(eax, 0x4);                          /* shr eax, 0x4 */
            ii(0x1017_ada5, 2); or(eax, ebx);                           /* or eax, ebx */
            ii(0x1017_ada7, 3); or(eax, memd_a32[ds, edx + 0x50]);      /* or eax, [edx+0x50] */
            ii(0x1017_adaa, 3); mov(memb_a32[ss, ebp - 0x2b], al);      /* mov [ebp-0x2b], al */
            ii(0x1017_adad, 6); mov(al, memb_a32[ds, edx + 0x90]);      /* mov al, [edx+0x90] */
            ii(0x1017_adb3, 6); mov(ah, memb_a32[ds, edx + 0x94]);      /* mov ah, [edx+0x94] */
            ii(0x1017_adb9, 3); shl(al, 0x5);                           /* shl al, 0x5 */
            ii(0x1017_adbc, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_adbe, 3); mov(memb_a32[ss, ebp - 0x2a], ah);      /* mov [ebp-0x2a], ah */
            ii(0x1017_adc1, 6); mov(al, memb_a32[ds, edx + 0x9c]);      /* mov al, [edx+0x9c] */
            ii(0x1017_adc7, 6); mov(ah, memb_a32[ds, edx + 0x98]);      /* mov ah, [edx+0x98] */
            ii(0x1017_adcd, 3); shl(al, 0x5);                           /* shl al, 0x5 */
            ii(0x1017_add0, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_add2, 3); mov(memb_a32[ss, ebp - 0x29], ah);      /* mov [ebp-0x29], ah */
            ii(0x1017_add5, 3); mov(eax, memd_a32[ds, edx + 0x58]);     /* mov eax, [edx+0x58] */
            ii(0x1017_add8, 3); shr(eax, 0x8);                          /* shr eax, 0x8 */
            ii(0x1017_addb, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1017_adde, 3); mov(al, memb_a32[ds, edx + 0x58]);      /* mov al, [edx+0x58] */
            ii(0x1017_ade1, 3); mov(memb_a32[ss, ebp - 0x27], al);      /* mov [ebp-0x27], al */
            ii(0x1017_ade4, 6); mov(eax, memd_a32[ds, edx + 0x8c]);     /* mov eax, [edx+0x8c] */
            ii(0x1017_adea, 3); shr(eax, 0x8);                          /* shr eax, 0x8 */
            ii(0x1017_aded, 3); mov(memb_a32[ss, ebp - 0x26], al);      /* mov [ebp-0x26], al */
            ii(0x1017_adf0, 6); mov(al, memb_a32[ds, edx + 0x8c]);      /* mov al, [edx+0x8c] */
            ii(0x1017_adf6, 3); mov(memb_a32[ss, ebp - 0x25], al);      /* mov [ebp-0x25], al */
            ii(0x1017_adf9, 3); mov(al, memb_a32[ds, edx + 0x38]);      /* mov al, [edx+0x38] */
            ii(0x1017_adfc, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1017_adff, 6); mov(ah, memb_a32[ds, edx + 0xa8]);      /* mov ah, [edx+0xa8] */
            ii(0x1017_ae05, 6); mov(al, memb_a32[ds, edx + 0xa0]);      /* mov al, [edx+0xa0] */
            ii(0x1017_ae0b, 3); shl(ah, 0x7);                           /* shl ah, 0x7 */
            ii(0x1017_ae0e, 3); shl(al, 0x6);                           /* shl al, 0x6 */
            ii(0x1017_ae11, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae13, 3); mov(al, memb_a32[ds, edx + 0x3c]);      /* mov al, [edx+0x3c] */
            ii(0x1017_ae16, 2); and(al, 0x3f);                          /* and al, 0x3f */
            ii(0x1017_ae18, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae1a, 3); mov(memb_a32[ss, ebp - 0x23], ah);      /* mov [ebp-0x23], ah */
            ii(0x1017_ae1d, 3); mov(al, memb_a32[ds, edx + 0x30]);      /* mov al, [edx+0x30] */
            ii(0x1017_ae20, 3); mov(memb_a32[ss, ebp - 0x22], al);      /* mov [ebp-0x22], al */
            ii(0x1017_ae23, 3); mov(eax, memd_a32[ds, edx + 0x5c]);     /* mov eax, [edx+0x5c] */
            ii(0x1017_ae26, 2); shr(eax, 0x1);                          /* shr eax, 1 */
            ii(0x1017_ae28, 3); mov(memb_a32[ss, ebp - 0x21], al);      /* mov [ebp-0x21], al */
            ii(0x1017_ae2b, 3); mov(ah, memb_a32[ds, edx + 0x60]);      /* mov ah, [edx+0x60] */
            ii(0x1017_ae2e, 3); mov(al, memb_a32[ds, edx + 0x64]);      /* mov al, [edx+0x64] */
            ii(0x1017_ae31, 3); shl(ah, 0x6);                           /* shl ah, 0x6 */
            ii(0x1017_ae34, 3); shl(al, 0x5);                           /* shl al, 0x5 */
            ii(0x1017_ae37, 2); or(al, ah);                             /* or al, ah */
            ii(0x1017_ae39, 3); mov(ah, memb_a32[ds, edx + 0x4c]);      /* mov ah, [edx+0x4c] */
            ii(0x1017_ae3c, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae3e, 3); mov(memb_a32[ss, ebp - 0x20], ah);      /* mov [ebp-0x20], ah */
            ii(0x1017_ae41, 3); mov(al, memb_a32[ds, edx + 0x34]);      /* mov al, [edx+0x34] */
            ii(0x1017_ae44, 3); mov(memb_a32[ss, ebp - 0x1f], al);      /* mov [ebp-0x1f], al */
            ii(0x1017_ae47, 3); mov(al, memb_a32[ds, edx + 0x40]);      /* mov al, [edx+0x40] */
            ii(0x1017_ae4a, 2); and(al, 0x7f);                          /* and al, 0x7f */
            ii(0x1017_ae4c, 3); mov(memb_a32[ss, ebp - 0x1e], al);      /* mov [ebp-0x1e], al */
            ii(0x1017_ae4f, 3); mov(ah, memb_a32[ds, edx + 0x6c]);      /* mov ah, [edx+0x6c] */
            ii(0x1017_ae52, 3); mov(al, memb_a32[ds, edx + 0x70]);      /* mov al, [edx+0x70] */
            ii(0x1017_ae55, 3); shl(ah, 0x7);                           /* shl ah, 0x7 */
            ii(0x1017_ae58, 3); shl(al, 0x6);                           /* shl al, 0x6 */
            ii(0x1017_ae5b, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae5d, 3); mov(al, memb_a32[ds, edx + 0x74]);      /* mov al, [edx+0x74] */
            ii(0x1017_ae60, 3); shl(al, 0x5);                           /* shl al, 0x5 */
            ii(0x1017_ae63, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae65, 3); mov(al, memb_a32[ds, edx + 0x78]);      /* mov al, [edx+0x78] */
            ii(0x1017_ae68, 3); shl(al, 0x4);                           /* shl al, 0x4 */
            ii(0x1017_ae6b, 2); or(al, ah);                             /* or al, ah */
            ii(0x1017_ae6d, 3); mov(ah, memb_a32[ds, edx + 0x7c]);      /* mov ah, [edx+0x7c] */
            ii(0x1017_ae70, 3); shl(ah, 0x3);                           /* shl ah, 0x3 */
            ii(0x1017_ae73, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae75, 6); mov(al, memb_a32[ds, edx + 0x80]);      /* mov al, [edx+0x80] */
            ii(0x1017_ae7b, 3); shl(al, 0x2);                           /* shl al, 0x2 */
            ii(0x1017_ae7e, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae80, 6); mov(al, memb_a32[ds, edx + 0x84]);      /* mov al, [edx+0x84] */
            ii(0x1017_ae86, 2); add(al, al);                            /* add al, al */
            ii(0x1017_ae88, 2); or(al, ah);                             /* or al, ah */
            ii(0x1017_ae8a, 6); mov(ah, memb_a32[ds, edx + 0x88]);      /* mov ah, [edx+0x88] */
            ii(0x1017_ae90, 2); or(ah, al);                             /* or ah, al */
            ii(0x1017_ae92, 3); mov(memb_a32[ss, ebp - 0x1d], ah);      /* mov [ebp-0x1d], ah */
            ii(0x1017_ae95, 3); mov(al, memb_a32[ds, edx + 0x44]);      /* mov al, [edx+0x44] */
            ii(0x1017_ae98, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
            ii(0x1017_ae9b, 3); cmp(memd_a32[ds, edx], 0);              /* cmp dword [edx], 0x0 */
            ii(0x1017_ae9e, 2); if(jzd(0x1017_aea6, 0x6)) goto l_0x1017_aea6; /* jz 0x1017aea6 */
            ii(0x1017_aea0, 4); mov(memb_a32[ss, ebp - 0x14], 0x6);     /* mov byte [ebp-0x14], 0x6 */
            ii(0x1017_aea4, 2); jmpd(0x1017_aeaa, 0x4); goto l_0x1017_aeaa; /* jmp 0x1017aeaa */
        l_0x1017_aea6:
            ii(0x1017_aea6, 4); mov(memb_a32[ss, ebp - 0x14], 0xe);     /* mov byte [ebp-0x14], 0xe */
        l_0x1017_aeaa:
            ii(0x1017_aeaa, 3); mov(al, memb_a32[ds, edx + 0x8]);       /* mov al, [edx+0x8] */
            ii(0x1017_aead, 3); mov(esi, memd_a32[ds, edx + 0x4]);      /* mov esi, [edx+0x4] */
            ii(0x1017_aeb0, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x1017_aeb3, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_aeb5, 2); if(jzd(0x1017_aec1, 0xa)) goto l_0x1017_aec1; /* jz 0x1017aec1 */
            ii(0x1017_aeb7, 2); pushd(0x13);                            /* push 0x13 */
            ii(0x1017_aeb9, 5); calld(/* sys */ 0x1019_41db, 0x1931d);  /* call 0x101941db */
            ii(0x1017_aebe, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1017_aec1:
            ii(0x1017_aec1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_aec3, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x1017_aec6, 1); pushd(eax);                             /* push eax */
            ii(0x1017_aec7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_aec9, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1017_aecc, 1); pushd(eax);                             /* push eax */
            ii(0x1017_aecd, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1017_aed0, 1); pushd(eax);                             /* push eax */
            ii(0x1017_aed1, 5); calld(/* sys */ 0x1019_41ed, 0x19317);  /* call 0x101941ed */
            ii(0x1017_aed6, 5); mov(eax, 0xa000_0000);                  /* mov eax, 0xa0000000 */
            ii(0x1017_aedb, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1017_aede, 5); mov(ebx, 0x1_0000);                     /* mov ebx, 0x10000 */
            ii(0x1017_aee3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_aee5, 5); calld(/* sys */ 0x1019_43d0, 0x194e6);  /* call 0x101943d0 */
            ii(0x1017_aeea, 5); calld(Definitions.sys_memset, -0x1510f); /* call 0x10165de0 */
        l_0x1017_aeef:
            ii(0x1017_aeef, 3); lea(esp, ebp - 0x10);                   /* lea esp, [ebp-0x10] */
            ii(0x1017_aef2, 1); popd(esi);                              /* pop esi */
            ii(0x1017_aef3, 1); popd(edx);                              /* pop edx */
            ii(0x1017_aef4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_aef5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_aef6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_aef7, 1); retd(); return;                         /* ret */
        }
    }
}
