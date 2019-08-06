using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("180d041f-dc92-41cf-9579-cc589d93a7af")]
        public void Method_100f_bbed()
        {
            ii(0x100f_bbed, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x100f_bbf2, 5); calld(Definitions.sys_check_available_stack_size, 0x6a15b); /* call 0x10165d52 */
            ii(0x100f_bbf7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_bbf8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_bbf9, 1); pushd(edx);                             /* push edx */
            ii(0x100f_bbfa, 1); pushd(esi);                             /* push esi */
            ii(0x100f_bbfb, 1); pushd(edi);                             /* push edi */
            ii(0x100f_bbfc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_bbfd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_bbff, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x100f_bc05, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_bc08, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_bc0c, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_bc0f, 6); mov(al, memb_a32[ds, eax + 0x101c_35c6]); /* mov al, [eax+0x101c35c6] */
            ii(0x100f_bc15, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100f_bc18, 4); or(memb_a32[ss, ebp - 0x14], 0x1);      /* or byte [ebp-0x14], 0x1 */
            ii(0x100f_bc1c, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bc1f, 5); calld(Definitions.my_ctor_0x101b38d0, -0x853e0); /* call 0x10076844 */
            ii(0x100f_bc24, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100f_bc27, 4); and(memb_a32[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x100f_bc2b, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100f_bc2f, 4); cmp(memb_a32[ss, ebp - 0x8], 0x1);      /* cmp byte [ebp-0x8], 0x1 */
            ii(0x100f_bc33, 2); if(jnzd(0x100f_bc75, 0x40)) goto l_0x100f_bc75; /* jnz 0x100fbc75 */
            ii(0x100f_bc35, 5); calld(0x100c_aa00, -0x3123a);           /* call 0x100caa00 */
            ii(0x100f_bc3a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_bc3f, 1); pushd(eax);                             /* push eax */
            ii(0x100f_bc40, 5); calld(0x100c_aa20, -0x31225);           /* call 0x100caa20 */
            ii(0x100f_bc45, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_bc47, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bc49, 5); mov(esi, StringDefinitions.SelectStartingLocation); /* mov esi, 0x101a28b3 */
            ii(0x100f_bc4e, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_bc50, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_bc52, 5); calld(0x1011_5d23, 0x1a0cc);            /* call 0x10115d23 */
            ii(0x100f_bc57, 5); calld(0x100d_5470, -0x267ec);           /* call 0x100d5470 */
            ii(0x100f_bc5c, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_bc5f, 5); mov(ebx, 0x463);                        /* mov ebx, 0x463 */
            ii(0x100f_bc64, 5); mov(edx, 0x45e);                        /* mov edx, 0x45e */
            ii(0x100f_bc69, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_bc6e, 5); calld(0x1013_daea, 0x41e77);            /* call 0x1013daea */
            ii(0x100f_bc73, 2); jmpd(0x100f_bc79, 0x4); goto l_0x100f_bc79; /* jmp 0x100fbc79 */
        l_0x100f_bc75:
            ii(0x100f_bc75, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100f_bc79:
            ii(0x100f_bc79, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_bc7d, 2); if(jzd(0x100f_bc85, 0x6)) goto l_0x100f_bc85; /* jz 0x100fbc85 */
            ii(0x100f_bc7f, 4); cmp(memb_a32[ss, ebp - 0x8], 0x6);      /* cmp byte [ebp-0x8], 0x6 */
            ii(0x100f_bc83, 2); if(jnzd(0x100f_bc8a, 0x5)) goto l_0x100f_bc8a; /* jnz 0x100fbc8a */
        l_0x100f_bc85:
            ii(0x100f_bc85, 5); jmpd(0x100f_bf54, 0x2ca); goto l_0x100f_bf54; /* jmp 0x100fbf54 */
        l_0x100f_bc8a:
            ii(0x100f_bc8a, 5); calld(0x100e_a903, -0x1138c);           /* call 0x100ea903 */
            ii(0x100f_bc8f, 7); mov(memb_a32[ds, 0x101c_391e], 0x7);    /* mov byte [0x101c391e], 0x7 */
            ii(0x100f_bc96, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_bc9a, 2); if(jzd(0x100f_bcac, 0x10)) goto l_0x100f_bcac; /* jz 0x100fbcac */
        l_0x100f_bc9c:
            ii(0x100f_bc9c, 7); cmp(memb_a32[ds, 0x101c_391e], 0x7);    /* cmp byte [0x101c391e], 0x7 */
            ii(0x100f_bca3, 2); if(jnzd(0x100f_bcac, 0x7)) goto l_0x100f_bcac; /* jnz 0x100fbcac */
            ii(0x100f_bca5, 5); calld(0x1010_132c, 0x5682);             /* call 0x1010132c */
            ii(0x100f_bcaa, 2); jmpd(0x100f_bc9c, -0x10); goto l_0x100f_bc9c; /* jmp 0x100fbc9c */
        l_0x100f_bcac:
            ii(0x100f_bcac, 7); cmp(memb_a32[ds, 0x101c_391e], 0xe);    /* cmp byte [0x101c391e], 0xe */
            ii(0x100f_bcb3, 2); if(jzd(0x100f_bcbe, 0x9)) goto l_0x100f_bcbe; /* jz 0x100fbcbe */
            ii(0x100f_bcb5, 7); cmp(memb_a32[ds, 0x101c_391e], 0x3);    /* cmp byte [0x101c391e], 0x3 */
            ii(0x100f_bcbc, 2); if(jnzd(0x100f_bcc0, 0x2)) goto l_0x100f_bcc0; /* jnz 0x100fbcc0 */
        l_0x100f_bcbe:
            ii(0x100f_bcbe, 2); jmpd(0x100f_bcc9, 0x9); goto l_0x100f_bcc9; /* jmp 0x100fbcc9 */
        l_0x100f_bcc0:
            ii(0x100f_bcc0, 7); cmp(memb_a32[ds, 0x101c_391e], 0xf);    /* cmp byte [0x101c391e], 0xf */
            ii(0x100f_bcc7, 2); if(jnzd(0x100f_bcd2, 0x9)) goto l_0x100f_bcd2; /* jnz 0x100fbcd2 */
        l_0x100f_bcc9:
            ii(0x100f_bcc9, 4); mov(memb_a32[ss, ebp - 0x8], 0x6);      /* mov byte [ebp-0x8], 0x6 */
            ii(0x100f_bccd, 5); jmpd(0x100f_bf54, 0x282); goto l_0x100f_bf54; /* jmp 0x100fbf54 */
        l_0x100f_bcd2:
            ii(0x100f_bcd2, 7); mov(memb_a32[ds, 0x101c_391e], 0x7);    /* mov byte [0x101c391e], 0x7 */
            ii(0x100f_bcd9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_bcde, 5); calld(0x1012_0d94, 0x250b1);            /* call 0x10120d94 */
            ii(0x100f_bce3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_bce7, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_bcea, 7); mov(ax, memw_a32[ds, eax + 0x101c_35bc]); /* mov ax, [eax+0x101c35bc] */
            ii(0x100f_bcf1, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100f_bcf4, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_bcf8, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_bcfb, 7); mov(ax, memw_a32[ds, eax + 0x101c_35be]); /* mov ax, [eax+0x101c35be] */
            ii(0x100f_bd02, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_bd05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bd07, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd0c, 5); calld(0x1013_ad11, 0x3f000);            /* call 0x1013ad11 */
            ii(0x100f_bd11, 2); test(al, al);                           /* test al, al */
            ii(0x100f_bd13, 6); if(jzd(0x100f_bda1, 0x88)) goto l_0x100f_bda1; /* jz 0x100fbda1 */
            ii(0x100f_bd19, 2); pushd(0);                               /* push 0x0 */
            ii(0x100f_bd1b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_bd1f, 1); pushd(eax);                             /* push eax */
            ii(0x100f_bd20, 4); movsx(ecx, memw_a32[ss, ebp - 0x38]);   /* movsx ecx, word [ebp-0x38] */
            ii(0x100f_bd24, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100f_bd28, 5); mov(edx, 0x30);                         /* mov edx, 0x30 */
            ii(0x100f_bd2d, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100f_bd30, 5); calld(0x1015_a6aa, 0x5e975);            /* call 0x1015a6aa */
            ii(0x100f_bd35, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bd37, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd3c, 5); calld(0x1008_ac18, -0x71129);           /* call 0x1008ac18 */
            ii(0x100f_bd41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bd43, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100f_bd46, 5); calld(0x1007_5f2c, -0x85e1f);           /* call 0x10075f2c */
            ii(0x100f_bd4b, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd50, 5); calld(0x1007_6574, -0x857e1);           /* call 0x10076574 */
            ii(0x100f_bd55, 4); mov(memb_a32[ds, eax + 0x3d], 0x10);    /* mov byte [eax+0x3d], 0x10 */
            ii(0x100f_bd59, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bd5e, 5); calld(0x1007_6574, -0x857ef);           /* call 0x10076574 */
            ii(0x100f_bd63, 5); calld(0x1007_623c, -0x85b2c);           /* call 0x1007623c */
            ii(0x100f_bd68, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bd6a, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bd6d, 5); calld(0x100c_b77c, -0x305f6);           /* call 0x100cb77c */
            ii(0x100f_bd72, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bd75, 5); calld(0x1007_6730, -0x8564a);           /* call 0x10076730 */
            ii(0x100f_bd7a, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100f_bd7e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_bd81, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bd84, 5); calld(0x1007_6730, -0x85659);           /* call 0x10076730 */
            ii(0x100f_bd89, 4); mov(ax, memw_a32[ds, eax + 0x17]);      /* mov ax, [eax+0x17] */
            ii(0x100f_bd8d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_bd90, 7); mov(memb_a32[ds, 0x101c_388a], 0x1);    /* mov byte [0x101c388a], 0x1 */
            ii(0x100f_bd97, 5); mov(al, memb_a32[ds, 0x101c_388a]);     /* mov al, [0x101c388a] */
            ii(0x100f_bd9c, 5); mov(memb_a32[ds, 0x101c_3889], al);     /* mov [0x101c3889], al */
        l_0x100f_bda1:
            ii(0x100f_bda1, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_bda5, 2); if(jzd(0x100f_bdad, 0x6)) goto l_0x100f_bdad; /* jz 0x100fbdad */
            ii(0x100f_bda7, 4); cmp(memb_a32[ss, ebp - 0x8], 0x2);      /* cmp byte [ebp-0x8], 0x2 */
            ii(0x100f_bdab, 2); if(jzd(0x100f_bdaf, 0x2)) goto l_0x100f_bdaf; /* jz 0x100fbdaf */
        l_0x100f_bdad:
            ii(0x100f_bdad, 2); jmpd(0x100f_be09, 0x5a); goto l_0x100f_be09; /* jmp 0x100fbe09 */
        l_0x100f_bdaf:
            ii(0x100f_bdaf, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x100f_bdb3, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x100f_bdb7, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_bdb9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_bdbb, 5); calld(/* sys */ 0x1016_5df8, 0x6a038);  /* call 0x10165df8 */
            ii(0x100f_bdc0, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100f_bdc3, 2); if(jgd(0x100f_bddb, 0x16)) goto l_0x100f_bddb; /* jg 0x100fbddb */
            ii(0x100f_bdc5, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100f_bdc9, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x100f_bdcd, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100f_bdcf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_bdd1, 5); calld(/* sys */ 0x1016_5df8, 0x6a022);  /* call 0x10165df8 */
            ii(0x100f_bdd6, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100f_bdd9, 2); if(jled(0x100f_bddd, 0x2)) goto l_0x100f_bddd; /* jle 0x100fbddd */
        l_0x100f_bddb:
            ii(0x100f_bddb, 2); jmpd(0x100f_be05, 0x28); goto l_0x100f_be05; /* jmp 0x100fbe05 */
        l_0x100f_bddd:
            ii(0x100f_bddd, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_bde1, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100f_bde4, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_bde7, 7); mov(memw_a32[ds, edx + 0x101c_35bc], ax); /* mov [edx+0x101c35bc], ax */
            ii(0x100f_bdee, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_bdf2, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100f_bdf5, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_bdf8, 7); mov(memw_a32[ds, edx + 0x101c_35be], ax); /* mov [edx+0x101c35be], ax */
            ii(0x100f_bdff, 4); mov(memb_a32[ss, ebp - 0x8], 0x4);      /* mov byte [ebp-0x8], 0x4 */
            ii(0x100f_be03, 2); jmpd(0x100f_be09, 0x4); goto l_0x100f_be09; /* jmp 0x100fbe09 */
        l_0x100f_be05:
            ii(0x100f_be05, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x100f_be09:
            ii(0x100f_be09, 4); cmp(memb_a32[ss, ebp - 0x8], 0x1);      /* cmp byte [ebp-0x8], 0x1 */
            ii(0x100f_be0d, 2); if(jzd(0x100f_be15, 0x6)) goto l_0x100f_be15; /* jz 0x100fbe15 */
            ii(0x100f_be0f, 4); cmp(memb_a32[ss, ebp - 0x8], 0x2);      /* cmp byte [ebp-0x8], 0x2 */
            ii(0x100f_be13, 2); if(jnzd(0x100f_be17, 0x2)) goto l_0x100f_be17; /* jnz 0x100fbe17 */
        l_0x100f_be15:
            ii(0x100f_be15, 2); jmpd(0x100f_be1d, 0x6); goto l_0x100f_be1d; /* jmp 0x100fbe1d */
        l_0x100f_be17:
            ii(0x100f_be17, 4); cmp(memb_a32[ss, ebp - 0x8], 0x3);      /* cmp byte [ebp-0x8], 0x3 */
            ii(0x100f_be1b, 2); if(jnzd(0x100f_be39, 0x1c)) goto l_0x100f_be39; /* jnz 0x100fbe39 */
        l_0x100f_be1d:
            ii(0x100f_be1d, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100f_be21, 4); movsx(edx, memw_a32[ss, ebp - 0x38]);   /* movsx edx, word [ebp-0x38] */
            ii(0x100f_be25, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_be2a, 5); calld(0x1008_abbc, -0x71273);           /* call 0x1008abbc */
            ii(0x100f_be2f, 5); calld(0x1016_309a, 0x67266);            /* call 0x1016309a */
            ii(0x100f_be34, 5); calld(0x100f_b889, -0x5b0);             /* call 0x100fb889 */
        l_0x100f_be39:
            ii(0x100f_be39, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100f_be3d, 3); imul(edx, edx, 0x13);                   /* imul edx, edx, 0x13 */
            ii(0x100f_be40, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_be43, 6); mov(memb_a32[ds, edx + 0x101c_35c6], al); /* mov [edx+0x101c35c6], al */
            ii(0x100f_be49, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_be50, 2); if(jzd(0x100f_be65, 0x13)) goto l_0x100f_be65; /* jz 0x100fbe65 */
            ii(0x100f_be52, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_be56, 5); calld(0x1012_8f02, 0x2d0a7);            /* call 0x10128f02 */
            ii(0x100f_be5b, 5); calld(0x1012_99ef, 0x2db8f);            /* call 0x101299ef */
            ii(0x100f_be60, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x100f_be63, 2); jmpd(0x100f_be7f, 0x1a); goto l_0x100f_be7f; /* jmp 0x100fbe7f */
        l_0x100f_be65:
            ii(0x100f_be65, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100f_be69, 2); if(jzd(0x100f_be79, 0xe)) goto l_0x100f_be79; /* jz 0x100fbe79 */
            ii(0x100f_be6b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_be6f, 5); calld(0x100f_bafc, -0x378);             /* call 0x100fbafc */
            ii(0x100f_be74, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x100f_be77, 2); jmpd(0x100f_be7f, 0x6); goto l_0x100f_be7f; /* jmp 0x100fbe7f */
        l_0x100f_be79:
            ii(0x100f_be79, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_be7c, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
        l_0x100f_be7f:
            ii(0x100f_be7f, 3); mov(al, memb_a32[ss, ebp - 0x34]);      /* mov al, [ebp-0x34] */
            ii(0x100f_be82, 3); mov(memb_a32[ss, ebp - 0x40], al);      /* mov [ebp-0x40], al */
            ii(0x100f_be85, 5); jmpd(0x100f_bf34, 0xaa); goto l_0x100f_bf34; /* jmp 0x100fbf34 */
        //  ii(0x100f_be8a, 139); Недостижимый код.
        l_0x100f_bf15:
            ii(0x100f_bf15, 2); jmpd(0x100f_bf4f, 0x38); goto l_0x100f_bf4f; /* jmp 0x100fbf4f */
        //  ii(0x100f_bf17, 29); Недостижимый код.
        l_0x100f_bf34:
            ii(0x100f_bf34, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x100f_bf37, 3); mov(memb_a32[ss, ebp - 0x44], al);      /* mov [ebp-0x44], al */
            ii(0x100f_bf3a, 4); cmp(memb_a32[ss, ebp - 0x44], 0x6);     /* cmp byte [ebp-0x44], 0x6 */
            ii(0x100f_bf3e, 2); if(jad(0x100f_bf15, -0x2b)) goto l_0x100f_bf15; /* ja 0x100fbf15 */
            ii(0x100f_bf40, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_bf42, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x100f_bf45, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_bf48, 7); jmpd_abs(memd_a32[cs, eax + 0x100f_bf18]); return; /* jmp dword [cs:eax+0x100fbf18] */
        l_0x100f_bf4f:
            ii(0x100f_bf4f, 5); jmpd(0x100f_bc79, -0x2db); goto l_0x100f_bc79; /* jmp 0x100fbc79 */
        l_0x100f_bf54:
            ii(0x100f_bf54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bf56, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bf5b, 5); calld(0x1013_ad71, 0x3ee11);            /* call 0x1013ad71 */
            ii(0x100f_bf60, 2); test(al, al);                           /* test al, al */
            ii(0x100f_bf62, 2); if(jzd(0x100f_bfa6, 0x42)) goto l_0x100f_bfa6; /* jz 0x100fbfa6 */
            ii(0x100f_bf64, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bf67, 5); calld(0x1007_6730, -0x8583c);           /* call 0x10076730 */
            ii(0x100f_bf6c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bf6e, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_bf71, 4); mov(memw_a32[ds, edx + 0x12], ax);      /* mov [edx+0x12], ax */
            ii(0x100f_bf75, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bf78, 5); calld(0x1007_6730, -0x8584d);           /* call 0x10076730 */
            ii(0x100f_bf7d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_bf7f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_bf82, 4); mov(memw_a32[ds, edx + 0x17], ax);      /* mov [edx+0x17], ax */
            ii(0x100f_bf86, 7); mov(memb_a32[ds, 0x101c_388a], 0);      /* mov byte [0x101c388a], 0x0 */
            ii(0x100f_bf8d, 5); mov(al, memb_a32[ds, 0x101c_388a]);     /* mov al, [0x101c388a] */
            ii(0x100f_bf92, 5); mov(memb_a32[ds, 0x101c_3889], al);     /* mov [0x101c3889], al */
            ii(0x100f_bf97, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_bf9c, 5); calld(0x1007_6600, -0x859a1);           /* call 0x10076600 */
            ii(0x100f_bfa1, 5); calld(0x1015_f2cc, 0x63326);            /* call 0x1015f2cc */
        l_0x100f_bfa6:
            ii(0x100f_bfa6, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_bfaa, 2); if(jnzd(0x100f_bfb2, 0x6)) goto l_0x100f_bfb2; /* jnz 0x100fbfb2 */
            ii(0x100f_bfac, 4); mov(memb_a32[ss, ebp - 0x48], 0x1);     /* mov byte [ebp-0x48], 0x1 */
            ii(0x100f_bfb0, 2); jmpd(0x100f_bfb6, 0x4); goto l_0x100f_bfb6; /* jmp 0x100fbfb6 */
        l_0x100f_bfb2:
            ii(0x100f_bfb2, 4); mov(memb_a32[ss, ebp - 0x48], 0);       /* mov byte [ebp-0x48], 0x0 */
        l_0x100f_bfb6:
            ii(0x100f_bfb6, 3); mov(al, memb_a32[ss, ebp - 0x48]);      /* mov al, [ebp-0x48] */
            ii(0x100f_bfb9, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100f_bfbc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_bfbe, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100f_bfc1, 5); calld(0x1007_5eec, -0x860da);           /* call 0x10075eec */
            ii(0x100f_bfc6, 2); jmpd(0x100f_bfd2, 0xa); goto l_0x100f_bfd2; /* jmp 0x100fbfd2 */
        //  ii(0x100f_bfc8, 10); Недостижимый код.
        l_0x100f_bfd2:
            ii(0x100f_bfd2, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100f_bfd5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_bfd7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_bfd8, 1); popd(edi);                              /* pop edi */
            ii(0x100f_bfd9, 1); popd(esi);                              /* pop esi */
            ii(0x100f_bfda, 1); popd(edx);                              /* pop edx */
            ii(0x100f_bfdb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_bfdc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_bfdd, 1); retd(); return;                         /* ret */
        }
    }
}
