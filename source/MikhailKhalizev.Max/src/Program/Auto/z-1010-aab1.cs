using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4b870a2b-6b15-4787-aec8-2b5126851fe1")]
        public void Method_1010_aab1()
        {
            ii(0x1010_aab1, 5); pushd(0x90);                            /* push 0x90 */
            ii(0x1010_aab6, 5); calld(Definitions.sys_check_available_stack_size, 0x5b297); /* call 0x10165d52 */
            ii(0x1010_aabb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_aabc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_aabd, 1); pushd(edx);                             /* push edx */
            ii(0x1010_aabe, 1); pushd(esi);                             /* push esi */
            ii(0x1010_aabf, 1); pushd(edi);                             /* push edi */
            ii(0x1010_aac0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_aac1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_aac3, 6); sub(esp, 0x68);                         /* sub esp, 0x68 */
            ii(0x1010_aac9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_aacc, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1010_aad1, 5); calld(0x1007_5fdc, -0x94afa);           /* call 0x10075fdc */
            ii(0x1010_aad6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_aad8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_aadb, 6); mov(memb_a32[ds, eax + 0x367], dl);     /* mov [eax+0x367], dl */
            ii(0x1010_aae1, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1010_aae6, 5); calld(0x1007_5fdc, -0x94b0f);           /* call 0x10075fdc */
            ii(0x1010_aaeb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_aaed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_aaf0, 7); mov(memw_a32[ds, eax + 0x368], dx);     /* mov [eax+0x368], dx */
            ii(0x1010_aaf7, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1010_aafc, 5); calld(0x1007_5fdc, -0x94b25);           /* call 0x10075fdc */
            ii(0x1010_ab01, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_ab03, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab06, 7); mov(memw_a32[ds, eax + 0x36a], dx);     /* mov [eax+0x36a], dx */
            ii(0x1010_ab0d, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x1010_ab12, 5); calld(0x1007_5fdc, -0x94b3b);           /* call 0x10075fdc */
            ii(0x1010_ab17, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_ab19, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab1c, 7); mov(memw_a32[ds, eax + 0x36d], dx);     /* mov [eax+0x36d], dx */
            ii(0x1010_ab23, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1010_ab28, 5); calld(0x1007_5fdc, -0x94b51);           /* call 0x10075fdc */
            ii(0x1010_ab2d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_ab2f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab32, 6); mov(memb_a32[ds, eax + 0x36c], dl);     /* mov [eax+0x36c], dl */
            ii(0x1010_ab38, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab3b, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1010_ab3e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_ab43, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1010_ab46, 2); if(jzd(0x1010_ab58, 0x10)) goto l_0x1010_ab58; /* jz 0x1010ab58 */
            ii(0x1010_ab48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab4b, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1010_ab4e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_ab53, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_ab56, 2); if(jnzd(0x1010_ab5a, 0x2)) goto l_0x1010_ab5a; /* jnz 0x1010ab5a */
        l_0x1010_ab58:
            ii(0x1010_ab58, 2); jmpd(0x1010_ab85, 0x2b); goto l_0x1010_ab85; /* jmp 0x1010ab85 */
        l_0x1010_ab5a:
            ii(0x1010_ab5a, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_ab5f, 5); calld(0x1007_5fdc, -0x94b88);           /* call 0x10075fdc */
            ii(0x1010_ab64, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_ab66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab69, 6); mov(memb_a32[ds, eax + 0x373], dl);     /* mov [eax+0x373], dl */
            ii(0x1010_ab6f, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_ab74, 5); calld(0x1007_5fdc, -0x94b9d);           /* call 0x10075fdc */
            ii(0x1010_ab79, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_ab7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab7e, 7); mov(memw_a32[ds, eax + 0x38c], dx);     /* mov [eax+0x38c], dx */
        l_0x1010_ab85:
            ii(0x1010_ab85, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1010_ab8a, 5); calld(0x1007_5fdc, -0x94bb3);           /* call 0x10075fdc */
            ii(0x1010_ab8f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_ab91, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ab94, 6); mov(memb_a32[ds, eax + 0x36f], dl);     /* mov [eax+0x36f], dl */
            ii(0x1010_ab9a, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1010_ab9f, 5); calld(0x1007_5fdc, -0x94bc8);           /* call 0x10075fdc */
            ii(0x1010_aba4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_aba6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_aba9, 6); mov(memb_a32[ds, eax + 0x370], dl);     /* mov [eax+0x370], dl */
            ii(0x1010_abaf, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1010_abb4, 5); calld(0x1007_5fdc, -0x94bdd);           /* call 0x10075fdc */
            ii(0x1010_abb9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_abbb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_abbe, 6); mov(memb_a32[ds, eax + 0x371], dl);     /* mov [eax+0x371], dl */
            ii(0x1010_abc4, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1010_abc9, 5); calld(0x1007_5fdc, -0x94bf2);           /* call 0x10075fdc */
            ii(0x1010_abce, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_abd0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_abd3, 6); mov(memb_a32[ds, eax + 0x372], dl);     /* mov [eax+0x372], dl */
            ii(0x1010_abd9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_abdb, 5); calld(0x100e_883d, -0x223a3);           /* call 0x100e883d */
            ii(0x1010_abe0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_abe2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_abe5, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1010_abe7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_abea, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1010_abf1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_abf4, 7); mov(memd_a32[ds, eax + 0x8], 0);        /* mov dword [eax+0x8], 0x0 */
            ii(0x1010_abfb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_abfe, 7); mov(memb_a32[ds, eax + 0x345], 0);      /* mov byte [eax+0x345], 0x0 */
            ii(0x1010_ac05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ac08, 10); mov(memd_a32[ds, eax + 0x341], 0);     /* mov dword [eax+0x341], 0x0 */
            ii(0x1010_ac12, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ac15, 10); mov(memd_a32[ds, eax + 0x363], 0);     /* mov dword [eax+0x363], 0x0 */
            ii(0x1010_ac1f, 5); calld(/* sys */ 0x1016_be34, 0x61210);  /* call 0x1016be34 */
            ii(0x1010_ac24, 5); calld(0x100d_533c, -0x358ed);           /* call 0x100d533c */
            ii(0x1010_ac29, 1); cwde();                                 /* cwde */
            ii(0x1010_ac2a, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ac2b, 5); calld(0x100d_5360, -0x358d0);           /* call 0x100d5360 */
            ii(0x1010_ac30, 1); cwde();                                 /* cwde */
            ii(0x1010_ac31, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ac32, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_ac34, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ac35, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_ac37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ac3a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_ac3c, 3); mov(ebx, memd_a32[ds, eax + 0xe]);      /* mov ebx, [eax+0xe] */
            ii(0x1010_ac3f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_ac42, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ac45, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_ac47, 5); mov(eax, 0x6f2);                        /* mov eax, 0x6f2 */
            ii(0x1010_ac4c, 5); calld(0x100e_8c51, -0x22000);           /* call 0x100e8c51 */
            ii(0x1010_ac51, 7); mov(memd_a32[ss, ebp - 0x8], 0x33);     /* mov dword [ebp-0x8], 0x33 */
        l_0x1010_ac58:
            ii(0x1010_ac58, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1010_ac5b, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_ac60, 6); if(jzd(0x1010_acf4, 0x8e)) goto l_0x1010_acf4; /* jz 0x1010acf4 */
            ii(0x1010_ac66, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_ac6a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_ac6d, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_ac70, 10); mov(memd_a32[ds, eax + 0x275], 0);     /* mov dword [eax+0x275], 0x0 */
            ii(0x1010_ac7a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_ac7e, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1010_ac81, 2); if(jgd(0x1010_aca5, 0x22)) goto l_0x1010_aca5; /* jg 0x1010aca5 */
            ii(0x1010_ac83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ac86, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1010_ac89, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_ac8e, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1010_ac91, 2); if(jzd(0x1010_aca3, 0x10)) goto l_0x1010_aca3; /* jz 0x1010aca3 */
            ii(0x1010_ac93, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_ac96, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1010_ac99, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_ac9e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_aca1, 2); if(jnzd(0x1010_aca5, 0x2)) goto l_0x1010_aca5; /* jnz 0x1010aca5 */
        l_0x1010_aca3:
            ii(0x1010_aca3, 2); jmpd(0x1010_aca7, 0x2); goto l_0x1010_aca7; /* jmp 0x1010aca7 */
        l_0x1010_aca5:
            ii(0x1010_aca5, 2); jmpd(0x1010_aca9, 0x2); goto l_0x1010_aca9; /* jmp 0x1010aca9 */
        l_0x1010_aca7:
            ii(0x1010_aca7, 2); jmpd(0x1010_acef, 0x46); goto l_0x1010_acef; /* jmp 0x1010acef */
        l_0x1010_aca9:
            ii(0x1010_aca9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_acad, 3); cmp(eax, 0x15);                         /* cmp eax, 0x15 */
            ii(0x1010_acb0, 2); if(jled(0x1010_acbb, 0x9)) goto l_0x1010_acbb; /* jle 0x1010acbb */
            ii(0x1010_acb2, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_acb6, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1010_acb9, 2); if(jld(0x1010_acbd, 0x2)) goto l_0x1010_acbd; /* jl 0x1010acbd */
        l_0x1010_acbb:
            ii(0x1010_acbb, 2); jmpd(0x1010_acdf, 0x22); goto l_0x1010_acdf; /* jmp 0x1010acdf */
        l_0x1010_acbd:
            ii(0x1010_acbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_acc0, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1010_acc3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_acc8, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1010_accb, 2); if(jzd(0x1010_acdd, 0x10)) goto l_0x1010_acdd; /* jz 0x1010acdd */
            ii(0x1010_accd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_acd0, 3); mov(al, memb_a32[ds, eax + 0xc]);       /* mov al, [eax+0xc] */
            ii(0x1010_acd3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_acd8, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1010_acdb, 2); if(jnzd(0x1010_acdf, 0x2)) goto l_0x1010_acdf; /* jnz 0x1010acdf */
        l_0x1010_acdd:
            ii(0x1010_acdd, 2); jmpd(0x1010_ace1, 0x2); goto l_0x1010_ace1; /* jmp 0x1010ace1 */
        l_0x1010_acdf:
            ii(0x1010_acdf, 2); jmpd(0x1010_ace3, 0x2); goto l_0x1010_ace3; /* jmp 0x1010ace3 */
        l_0x1010_ace1:
            ii(0x1010_ace1, 2); jmpd(0x1010_acef, 0xc); goto l_0x1010_acef; /* jmp 0x1010acef */
        l_0x1010_ace3:
            ii(0x1010_ace3, 4); movsx(edx, memb_a32[ss, ebp - 0x8]);    /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_ace7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_acea, 5); calld(0x1010_9fa6, -0xd49);             /* call 0x10109fa6 */
        l_0x1010_acef:
            ii(0x1010_acef, 5); jmpd(0x1010_ac58, -0x9c); goto l_0x1010_ac58; /* jmp 0x1010ac58 */
        l_0x1010_acf4:
            ii(0x1010_acf4, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_acf9, 5); calld(Definitions.sys_new, 0x5b102);    /* call 0x10165e00 */
            ii(0x1010_acfe, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1010_ad01, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_ad04, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1010_ad07, 4); cmp(memd_a32[ss, ebp - 0x48], 0);       /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1010_ad0b, 2); if(jzd(0x1010_ad35, 0x28)) goto l_0x1010_ad35; /* jz 0x1010ad35 */
            ii(0x1010_ad0d, 5); mov(eax, 0xbe);                         /* mov eax, 0xbe */
            ii(0x1010_ad12, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ad13, 5); mov(ecx, 0xc8);                         /* mov ecx, 0xc8 */
            ii(0x1010_ad18, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1010_ad1d, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1010_ad22, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1010_ad25, 5); calld(0x100d_7bdc, -0x3314e);           /* call 0x100d7bdc */
            ii(0x1010_ad2a, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1010_ad2d, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1010_ad30, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1010_ad33, 2); jmpd(0x1010_ad3b, 0x6); goto l_0x1010_ad3b; /* jmp 0x1010ad3b */
        l_0x1010_ad35:
            ii(0x1010_ad35, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1010_ad38, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
        l_0x1010_ad3b:
            ii(0x1010_ad3b, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1010_ad3e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_ad41, 6); mov(memd_a32[ds, edx + 0x374], eax);    /* mov [edx+0x374], eax */
            ii(0x1010_ad47, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_ad4c, 5); calld(Definitions.sys_new, 0x5b0af);    /* call 0x10165e00 */
            ii(0x1010_ad51, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1010_ad54, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_ad57, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1010_ad5a, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1010_ad5e, 2); if(jzd(0x1010_ad88, 0x28)) goto l_0x1010_ad88; /* jz 0x1010ad88 */
            ii(0x1010_ad60, 5); mov(eax, 0xbe);                         /* mov eax, 0xbe */
            ii(0x1010_ad65, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ad66, 5); mov(ecx, 0xc8);                         /* mov ecx, 0xc8 */
            ii(0x1010_ad6b, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1010_ad70, 5); mov(edx, 0xd8);                         /* mov edx, 0xd8 */
            ii(0x1010_ad75, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1010_ad78, 5); calld(0x100d_7bdc, -0x331a1);           /* call 0x100d7bdc */
            ii(0x1010_ad7d, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1010_ad80, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1010_ad83, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1010_ad86, 2); jmpd(0x1010_ad8e, 0x6); goto l_0x1010_ad8e; /* jmp 0x1010ad8e */
        l_0x1010_ad88:
            ii(0x1010_ad88, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1010_ad8b, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
        l_0x1010_ad8e:
            ii(0x1010_ad8e, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1010_ad91, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_ad94, 6); mov(memd_a32[ds, edx + 0x378], eax);    /* mov [edx+0x378], eax */
            ii(0x1010_ad9a, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_ad9f, 5); calld(Definitions.sys_new, 0x5b05c);    /* call 0x10165e00 */
            ii(0x1010_ada4, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1010_ada7, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_adaa, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1010_adad, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1010_adb1, 2); if(jzd(0x1010_addb, 0x28)) goto l_0x1010_addb; /* jz 0x1010addb */
            ii(0x1010_adb3, 5); mov(eax, 0xbe);                         /* mov eax, 0xbe */
            ii(0x1010_adb8, 1); pushd(eax);                             /* push eax */
            ii(0x1010_adb9, 5); mov(ecx, 0xc8);                         /* mov ecx, 0xc8 */
            ii(0x1010_adbe, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1010_adc3, 5); mov(edx, 0x1aa);                        /* mov edx, 0x1aa */
            ii(0x1010_adc8, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1010_adcb, 5); calld(0x100d_7bdc, -0x331f4);           /* call 0x100d7bdc */
            ii(0x1010_add0, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1010_add3, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1010_add6, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1010_add9, 2); jmpd(0x1010_ade1, 0x6); goto l_0x1010_ade1; /* jmp 0x1010ade1 */
        l_0x1010_addb:
            ii(0x1010_addb, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1010_adde, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
        l_0x1010_ade1:
            ii(0x1010_ade1, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1010_ade4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_ade7, 6); mov(memd_a32[ds, edx + 0x37c], eax);    /* mov [edx+0x37c], eax */
            ii(0x1010_aded, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_adf2, 5); calld(Definitions.sys_new, 0x5b009);    /* call 0x10165e00 */
            ii(0x1010_adf7, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_adfa, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_adfd, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1010_ae00, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1010_ae04, 2); if(jzd(0x1010_ae2e, 0x28)) goto l_0x1010_ae2e; /* jz 0x1010ae2e */
            ii(0x1010_ae06, 5); mov(eax, 0xbe);                         /* mov eax, 0xbe */
            ii(0x1010_ae0b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ae0c, 5); mov(ecx, 0xc8);                         /* mov ecx, 0xc8 */
            ii(0x1010_ae11, 5); mov(ebx, 0xe9);                         /* mov ebx, 0xe9 */
            ii(0x1010_ae16, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1010_ae1b, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_ae1e, 5); calld(0x100d_7bdc, -0x33247);           /* call 0x100d7bdc */
            ii(0x1010_ae23, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1010_ae26, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1010_ae29, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1010_ae2c, 2); jmpd(0x1010_ae34, 0x6); goto l_0x1010_ae34; /* jmp 0x1010ae34 */
        l_0x1010_ae2e:
            ii(0x1010_ae2e, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1010_ae31, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
        l_0x1010_ae34:
            ii(0x1010_ae34, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1010_ae37, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_ae3a, 6); mov(memd_a32[ds, edx + 0x380], eax);    /* mov [edx+0x380], eax */
            ii(0x1010_ae40, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_ae45, 5); calld(Definitions.sys_new, 0x5afb6);    /* call 0x10165e00 */
            ii(0x1010_ae4a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_ae4d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_ae50, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_ae53, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1010_ae57, 2); if(jzd(0x1010_ae81, 0x28)) goto l_0x1010_ae81; /* jz 0x1010ae81 */
            ii(0x1010_ae59, 5); mov(eax, 0xbe);                         /* mov eax, 0xbe */
            ii(0x1010_ae5e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_ae5f, 5); mov(ecx, 0xc8);                         /* mov ecx, 0xc8 */
            ii(0x1010_ae64, 5); mov(ebx, 0xe9);                         /* mov ebx, 0xe9 */
            ii(0x1010_ae69, 5); mov(edx, 0xd8);                         /* mov edx, 0xd8 */
            ii(0x1010_ae6e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_ae71, 5); calld(0x100d_7bdc, -0x3329a);           /* call 0x100d7bdc */
            ii(0x1010_ae76, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_ae79, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_ae7c, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1010_ae7f, 2); jmpd(0x1010_ae87, 0x6); goto l_0x1010_ae87; /* jmp 0x1010ae87 */
        l_0x1010_ae81:
            ii(0x1010_ae81, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_ae84, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
        l_0x1010_ae87:
            ii(0x1010_ae87, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1010_ae8a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_ae8d, 6); mov(memd_a32[ds, edx + 0x384], eax);    /* mov [edx+0x384], eax */
            ii(0x1010_ae93, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1010_ae98, 5); calld(Definitions.sys_new, 0x5af63);    /* call 0x10165e00 */
            ii(0x1010_ae9d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_aea0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_aea3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_aea6, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1010_aeaa, 2); if(jzd(0x1010_aed4, 0x28)) goto l_0x1010_aed4; /* jz 0x1010aed4 */
            ii(0x1010_aeac, 5); mov(eax, 0xbe);                         /* mov eax, 0xbe */
            ii(0x1010_aeb1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_aeb2, 5); mov(ecx, 0xc8);                         /* mov ecx, 0xc8 */
            ii(0x1010_aeb7, 5); mov(ebx, 0xe9);                         /* mov ebx, 0xe9 */
            ii(0x1010_aebc, 5); mov(edx, 0x1aa);                        /* mov edx, 0x1aa */
            ii(0x1010_aec1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_aec4, 5); calld(0x100d_7bdc, -0x332ed);           /* call 0x100d7bdc */
            ii(0x1010_aec9, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_aecc, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_aecf, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1010_aed2, 2); jmpd(0x1010_aeda, 0x6); goto l_0x1010_aeda; /* jmp 0x1010aeda */
        l_0x1010_aed4:
            ii(0x1010_aed4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_aed7, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
        l_0x1010_aeda:
            ii(0x1010_aeda, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1010_aedd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_aee0, 6); mov(memd_a32[ds, edx + 0x388], eax);    /* mov [edx+0x388], eax */
            ii(0x1010_aee6, 6); mov(memw_a32[ss, ebp - 0x8], 0x6);      /* mov word [ebp-0x8], 0x6 */
        l_0x1010_aeec:
            ii(0x1010_aeec, 4); dec(memw_a32[ss, ebp - 0x8]);           /* dec word [ebp-0x8] */
            ii(0x1010_aef0, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_aef5, 2); if(jzd(0x1010_af13, 0x1c)) goto l_0x1010_af13; /* jz 0x1010af13 */
            ii(0x1010_aef7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_aefa, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1010_aefc, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_af00, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_af03, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1010_af06, 6); mov(eax, memd_a32[ds, eax + 0x374]);    /* mov eax, [eax+0x374] */
            ii(0x1010_af0c, 5); calld(0x100d_7d74, -0x3319d);           /* call 0x100d7d74 */
            ii(0x1010_af11, 2); jmpd(0x1010_aeec, -0x27); goto l_0x1010_aeec; /* jmp 0x1010aeec */
        l_0x1010_af13:
            ii(0x1010_af13, 5); calld(0x1011_5318, 0xa400);             /* call 0x10115318 */
            ii(0x1010_af18, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_af1d, 1); pushd(eax);                             /* push eax */
            ii(0x1010_af1e, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1010_af23, 5); mov(ebx, 0x1_0002);                     /* mov ebx, 0x10002 */
            ii(0x1010_af28, 5); mov(edx, 0x101b_a5ac);                  /* mov edx, 0x101ba5ac */
            ii(0x1010_af2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_af30, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_af32, 5); calld(0x1010_8a05, -0x2532);            /* call 0x10108a05 */
            ii(0x1010_af37, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_af3a, 5); calld(0x1010_aa10, -0x52f);             /* call 0x1010aa10 */
            ii(0x1010_af3f, 5); calld(/* sys */ 0x1016_bcc4, 0x60d80);  /* call 0x1016bcc4 */
            ii(0x1010_af44, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_af46, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_af47, 1); popd(edi);                              /* pop edi */
            ii(0x1010_af48, 1); popd(esi);                              /* pop esi */
            ii(0x1010_af49, 1); popd(edx);                              /* pop edx */
            ii(0x1010_af4a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_af4b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_af4c, 1); retd(); return;                         /* ret */
        }
    }
}
