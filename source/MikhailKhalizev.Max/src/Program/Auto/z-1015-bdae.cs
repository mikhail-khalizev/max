using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_bdae-3b317080")]
        public void Method_1015_bdae()
        {
            ii(0x1015_bdae, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1015_bdb3, 5); calld(Definitions.sys_check_available_stack_size, 0x9f9a); /* call 0x10165d52 */
            ii(0x1015_bdb8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_bdb9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_bdba, 1); pushd(edx);                             /* push edx */
            ii(0x1015_bdbb, 1); pushd(esi);                             /* push esi */
            ii(0x1015_bdbc, 1); pushd(edi);                             /* push edi */
            ii(0x1015_bdbd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_bdbe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_bdc0, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1015_bdc6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_bdc9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_bdcb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_bdce, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_bdd1, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_bdd4, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1015_bdd8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bddb, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xe_56f0); /* call 0x100766f0 */
            ii(0x1015_bde0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_bde3, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1015_bde7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_bdea, 5); calld(0x1014_9fa8, -0x1_1e47);          /* call 0x10149fa8 */
            ii(0x1015_bdef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_bdf2, 7); test(memd_a32[ds, eax + 0x12], 0x80_0018); /* test dword [eax+0x12], 0x800018 */
            ii(0x1015_bdf9, 2); if(jzd(0x1015_be04, 0x9)) goto l_0x1015_be04; /* jz 0x1015be04 */
            ii(0x1015_bdfb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_bdfe, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x1015_be02, 2); if(jzd(0x1015_be13, 0xf)) goto l_0x1015_be13; /* jz 0x1015be13 */
        l_0x1015_be04:
            ii(0x1015_be04, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_be06, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_be09, 5); calld(0x1007_5f2c, -0xe_5ee2);          /* call 0x10075f2c */
            ii(0x1015_be0e, 5); jmpd(0x1015_c330, 0x51d); goto l_0x1015_c330; /* jmp 0x1015c330 */
        l_0x1015_be13:
            ii(0x1015_be13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_be16, 5); calld(0x1014_c28b, -0xfb90);            /* call 0x1014c28b */
            ii(0x1015_be1b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_be1e, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1015_be22, 2); if(jzd(0x1015_be2d, 0x9)) goto l_0x1015_be2d; /* jz 0x1015be2d */
            ii(0x1015_be24, 7); mov(memd_a32[ss, ebp - 0x24], 0x2);     /* mov dword [ebp-0x24], 0x2 */
            ii(0x1015_be2b, 2); jmpd(0x1015_be34, 0x7); goto l_0x1015_be34; /* jmp 0x1015be34 */
        l_0x1015_be2d:
            ii(0x1015_be2d, 7); mov(memd_a32[ss, ebp - 0x24], 0x1);     /* mov dword [ebp-0x24], 0x1 */
        l_0x1015_be34:
            ii(0x1015_be34, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_be37, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_be3a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_be3d, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1015_be41, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_be44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_be47, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1015_be4b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_be4e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_be51, 4); test(memb_a32[ds, eax + 0x69], 0x1);    /* test byte [eax+0x69], 0x1 */
            ii(0x1015_be55, 6); if(jzd(0x1015_bee8, 0x8d)) goto l_0x1015_bee8; /* jz 0x1015bee8 */
            ii(0x1015_be5b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_be5e, 1); dec(eax);                               /* dec eax */
            ii(0x1015_be5f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_be62, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_be66, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_be6a, 5); calld(0x1007_5331, -0xe_6b3e);          /* call 0x10075331 */
            ii(0x1015_be6f, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_be72, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_be74, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_be76, 5); calld(0x1007_6630, -0xe_584b);          /* call 0x10076630 */
            ii(0x1015_be7b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_be7e, 5); calld(0x1007_6574, -0xe_590f);          /* call 0x10076574 */
            ii(0x1015_be83, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_be8a, 2); if(jzd(0x1015_be9a, 0xe)) goto l_0x1015_be9a; /* jz 0x1015be9a */
            ii(0x1015_be8c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_be8f, 5); calld(0x1007_6574, -0xe_5920);          /* call 0x10076574 */
            ii(0x1015_be94, 4); and(memb_a32[ds, eax + 0x69], -0x11 /* 0xef */); /* and byte [eax+0x69], 0xef */
            ii(0x1015_be98, 2); jmpd(0x1015_bedb, 0x41); goto l_0x1015_bedb; /* jmp 0x1015bedb */
        l_0x1015_be9a:
            ii(0x1015_be9a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_be9d, 1); dec(eax);                               /* dec eax */
            ii(0x1015_be9e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_bea1, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_bea4, 1); inc(eax);                               /* inc eax */
            ii(0x1015_bea5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_bea8, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_beac, 5); calld(0x1007_5331, -0xe_6b80);          /* call 0x10075331 */
            ii(0x1015_beb1, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_beb4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_beb6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_beb8, 5); calld(0x1007_6e00, -0xe_50bd);          /* call 0x10076e00 */
            ii(0x1015_bebd, 2); test(al, al);                           /* test al, al */
            ii(0x1015_bebf, 2); if(jzd(0x1015_becf, 0xe)) goto l_0x1015_becf; /* jz 0x1015becf */
            ii(0x1015_bec1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bec4, 5); calld(0x1007_6574, -0xe_5955);          /* call 0x10076574 */
            ii(0x1015_bec9, 4); and(memb_a32[ds, eax + 0x69], -0x11 /* 0xef */); /* and byte [eax+0x69], 0xef */
            ii(0x1015_becd, 2); jmpd(0x1015_bedb, 0xc); goto l_0x1015_bedb; /* jmp 0x1015bedb */
        l_0x1015_becf:
            ii(0x1015_becf, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bed2, 5); calld(0x1007_6574, -0xe_5963);          /* call 0x10076574 */
            ii(0x1015_bed7, 4); and(memb_a32[ds, eax + 0x69], -0x21 /* 0xdf */); /* and byte [eax+0x69], 0xdf */
        l_0x1015_bedb:
            ii(0x1015_bedb, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bede, 5); calld(0x1007_6574, -0xe_596f);          /* call 0x10076574 */
            ii(0x1015_bee3, 5); calld(0x1014_9fa8, -0x1_1f40);          /* call 0x10149fa8 */
        l_0x1015_bee8:
            ii(0x1015_bee8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_beeb, 4); test(memb_a32[ds, eax + 0x69], 0x2);    /* test byte [eax+0x69], 0x2 */
            ii(0x1015_beef, 6); if(jzd(0x1015_bf80, 0x8b)) goto l_0x1015_bf80; /* jz 0x1015bf80 */
            ii(0x1015_bef5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_bef8, 1); dec(eax);                               /* dec eax */
            ii(0x1015_bef9, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_befc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_beff, 1); inc(eax);                               /* inc eax */
            ii(0x1015_bf00, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_bf03, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_bf07, 5); calld(0x1007_5331, -0xe_6bdb);          /* call 0x10075331 */
            ii(0x1015_bf0c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_bf0e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bf11, 5); calld(0x1007_6630, -0xe_58e6);          /* call 0x10076630 */
            ii(0x1015_bf16, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bf19, 5); calld(0x1007_6574, -0xe_59aa);          /* call 0x10076574 */
            ii(0x1015_bf1e, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_bf25, 2); if(jzd(0x1015_bf35, 0xe)) goto l_0x1015_bf35; /* jz 0x1015bf35 */
            ii(0x1015_bf27, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bf2a, 5); calld(0x1007_6574, -0xe_59bb);          /* call 0x10076574 */
            ii(0x1015_bf2f, 4); and(memb_a32[ds, eax + 0x69], -0x11 /* 0xef */); /* and byte [eax+0x69], 0xef */
            ii(0x1015_bf33, 2); jmpd(0x1015_bf73, 0x3e); goto l_0x1015_bf73; /* jmp 0x1015bf73 */
        l_0x1015_bf35:
            ii(0x1015_bf35, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_bf38, 1); dec(eax);                               /* dec eax */
            ii(0x1015_bf39, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_bf3c, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_bf40, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_bf44, 5); calld(0x1007_5331, -0xe_6c18);          /* call 0x10075331 */
            ii(0x1015_bf49, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_bf4c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_bf4e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_bf50, 5); calld(0x1007_6e00, -0xe_5155);          /* call 0x10076e00 */
            ii(0x1015_bf55, 2); test(al, al);                           /* test al, al */
            ii(0x1015_bf57, 2); if(jzd(0x1015_bf67, 0xe)) goto l_0x1015_bf67; /* jz 0x1015bf67 */
            ii(0x1015_bf59, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bf5c, 5); calld(0x1007_6574, -0xe_59ed);          /* call 0x10076574 */
            ii(0x1015_bf61, 4); and(memb_a32[ds, eax + 0x69], -0x21 /* 0xdf */); /* and byte [eax+0x69], 0xdf */
            ii(0x1015_bf65, 2); jmpd(0x1015_bf73, 0xc); goto l_0x1015_bf73; /* jmp 0x1015bf73 */
        l_0x1015_bf67:
            ii(0x1015_bf67, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bf6a, 5); calld(0x1007_6574, -0xe_59fb);          /* call 0x10076574 */
            ii(0x1015_bf6f, 4); and(memb_a32[ds, eax + 0x69], -0x11 /* 0xef */); /* and byte [eax+0x69], 0xef */
        l_0x1015_bf73:
            ii(0x1015_bf73, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bf76, 5); calld(0x1007_6574, -0xe_5a07);          /* call 0x10076574 */
            ii(0x1015_bf7b, 5); calld(0x1014_9fa8, -0x1_1fd8);          /* call 0x10149fa8 */
        l_0x1015_bf80:
            ii(0x1015_bf80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_bf83, 4); test(memb_a32[ds, eax + 0x69], 0x4);    /* test byte [eax+0x69], 0x4 */
            ii(0x1015_bf87, 6); if(jzd(0x1015_c01e, 0x91)) goto l_0x1015_c01e; /* jz 0x1015c01e */
            ii(0x1015_bf8d, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_bf91, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_bf94, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_bf97, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_bf9a, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_bf9e, 5); calld(0x1007_5331, -0xe_6c72);          /* call 0x10075331 */
            ii(0x1015_bfa3, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_bfa6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_bfa8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_bfaa, 5); calld(0x1007_6630, -0xe_597f);          /* call 0x10076630 */
            ii(0x1015_bfaf, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bfb2, 5); calld(0x1007_6574, -0xe_5a43);          /* call 0x10076574 */
            ii(0x1015_bfb7, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_bfbe, 2); if(jzd(0x1015_bfce, 0xe)) goto l_0x1015_bfce; /* jz 0x1015bfce */
            ii(0x1015_bfc0, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bfc3, 5); calld(0x1007_6574, -0xe_5a54);          /* call 0x10076574 */
            ii(0x1015_bfc8, 4); and(memb_a32[ds, eax + 0x69], -0x41 /* 0xbf */); /* and byte [eax+0x69], 0xbf */
            ii(0x1015_bfcc, 2); jmpd(0x1015_c011, 0x43); goto l_0x1015_c011; /* jmp 0x1015c011 */
        l_0x1015_bfce:
            ii(0x1015_bfce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_bfd1, 1); inc(eax);                               /* inc eax */
            ii(0x1015_bfd2, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_bfd5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_bfd8, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_bfdb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_bfde, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_bfe2, 5); calld(0x1007_5331, -0xe_6cb6);          /* call 0x10075331 */
            ii(0x1015_bfe7, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_bfea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_bfec, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_bfee, 5); calld(0x1007_6e00, -0xe_51f3);          /* call 0x10076e00 */
            ii(0x1015_bff3, 2); test(al, al);                           /* test al, al */
            ii(0x1015_bff5, 2); if(jzd(0x1015_c005, 0xe)) goto l_0x1015_c005; /* jz 0x1015c005 */
            ii(0x1015_bff7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_bffa, 5); calld(0x1007_6574, -0xe_5a8b);          /* call 0x10076574 */
            ii(0x1015_bfff, 4); and(memb_a32[ds, eax + 0x69], -0x41 /* 0xbf */); /* and byte [eax+0x69], 0xbf */
            ii(0x1015_c003, 2); jmpd(0x1015_c011, 0xc); goto l_0x1015_c011; /* jmp 0x1015c011 */
        l_0x1015_c005:
            ii(0x1015_c005, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c008, 5); calld(0x1007_6574, -0xe_5a99);          /* call 0x10076574 */
            ii(0x1015_c00d, 4); and(memb_a32[ds, eax + 0x69], 0x7f);    /* and byte [eax+0x69], 0x7f */
        l_0x1015_c011:
            ii(0x1015_c011, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c014, 5); calld(0x1007_6574, -0xe_5aa5);          /* call 0x10076574 */
            ii(0x1015_c019, 5); calld(0x1014_9fa8, -0x1_2076);          /* call 0x10149fa8 */
        l_0x1015_c01e:
            ii(0x1015_c01e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c021, 4); test(memb_a32[ds, eax + 0x69], 0x8);    /* test byte [eax+0x69], 0x8 */
            ii(0x1015_c025, 6); if(jzd(0x1015_c0ba, 0x8f)) goto l_0x1015_c0ba; /* jz 0x1015c0ba */
            ii(0x1015_c02b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_c02e, 1); inc(eax);                               /* inc eax */
            ii(0x1015_c02f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_c032, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c035, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_c038, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c03b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c03f, 5); calld(0x1007_5331, -0xe_6d13);          /* call 0x10075331 */
            ii(0x1015_c044, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c046, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c049, 5); calld(0x1007_6630, -0xe_5a1e);          /* call 0x10076630 */
            ii(0x1015_c04e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c051, 5); calld(0x1007_6574, -0xe_5ae2);          /* call 0x10076574 */
            ii(0x1015_c056, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_c05d, 2); if(jzd(0x1015_c06d, 0xe)) goto l_0x1015_c06d; /* jz 0x1015c06d */
            ii(0x1015_c05f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c062, 5); calld(0x1007_6574, -0xe_5af3);          /* call 0x10076574 */
            ii(0x1015_c067, 4); and(memb_a32[ds, eax + 0x69], -0x41 /* 0xbf */); /* and byte [eax+0x69], 0xbf */
            ii(0x1015_c06b, 2); jmpd(0x1015_c0ad, 0x40); goto l_0x1015_c0ad; /* jmp 0x1015c0ad */
        l_0x1015_c06d:
            ii(0x1015_c06d, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_c071, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c074, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_c077, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c07a, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c07e, 5); calld(0x1007_5331, -0xe_6d52);          /* call 0x10075331 */
            ii(0x1015_c083, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_c086, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c088, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c08a, 5); calld(0x1007_6e00, -0xe_528f);          /* call 0x10076e00 */
            ii(0x1015_c08f, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c091, 2); if(jzd(0x1015_c0a1, 0xe)) goto l_0x1015_c0a1; /* jz 0x1015c0a1 */
            ii(0x1015_c093, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c096, 5); calld(0x1007_6574, -0xe_5b27);          /* call 0x10076574 */
            ii(0x1015_c09b, 4); and(memb_a32[ds, eax + 0x69], 0x7f);    /* and byte [eax+0x69], 0x7f */
            ii(0x1015_c09f, 2); jmpd(0x1015_c0ad, 0xc); goto l_0x1015_c0ad; /* jmp 0x1015c0ad */
        l_0x1015_c0a1:
            ii(0x1015_c0a1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c0a4, 5); calld(0x1007_6574, -0xe_5b35);          /* call 0x10076574 */
            ii(0x1015_c0a9, 4); and(memb_a32[ds, eax + 0x69], -0x41 /* 0xbf */); /* and byte [eax+0x69], 0xbf */
        l_0x1015_c0ad:
            ii(0x1015_c0ad, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c0b0, 5); calld(0x1007_6574, -0xe_5b41);          /* call 0x10076574 */
            ii(0x1015_c0b5, 5); calld(0x1014_9fa8, -0x1_2112);          /* call 0x10149fa8 */
        l_0x1015_c0ba:
            ii(0x1015_c0ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c0bd, 4); test(memb_a32[ds, eax + 0x69], 0x10);   /* test byte [eax+0x69], 0x10 */
            ii(0x1015_c0c1, 6); if(jzd(0x1015_c158, 0x91)) goto l_0x1015_c158; /* jz 0x1015c158 */
            ii(0x1015_c0c7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_c0ca, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_c0cd, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_c0d0, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_c0d4, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c0d8, 5); calld(0x1007_5331, -0xe_6dac);          /* call 0x10075331 */
            ii(0x1015_c0dd, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_c0e0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c0e2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c0e4, 5); calld(0x1007_6630, -0xe_5ab9);          /* call 0x10076630 */
            ii(0x1015_c0e9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c0ec, 5); calld(0x1007_6574, -0xe_5b7d);          /* call 0x10076574 */
            ii(0x1015_c0f1, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_c0f8, 2); if(jzd(0x1015_c108, 0xe)) goto l_0x1015_c108; /* jz 0x1015c108 */
            ii(0x1015_c0fa, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c0fd, 5); calld(0x1007_6574, -0xe_5b8e);          /* call 0x10076574 */
            ii(0x1015_c102, 4); and(memb_a32[ds, eax + 0x69], -0x2 /* 0xfe */); /* and byte [eax+0x69], 0xfe */
            ii(0x1015_c106, 2); jmpd(0x1015_c14b, 0x43); goto l_0x1015_c14b; /* jmp 0x1015c14b */
        l_0x1015_c108:
            ii(0x1015_c108, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_c10b, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_c10e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_c111, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c114, 1); inc(eax);                               /* inc eax */
            ii(0x1015_c115, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c118, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c11c, 5); calld(0x1007_5331, -0xe_6df0);          /* call 0x10075331 */
            ii(0x1015_c121, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_c124, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c126, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c128, 5); calld(0x1007_6e00, -0xe_532d);          /* call 0x10076e00 */
            ii(0x1015_c12d, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c12f, 2); if(jzd(0x1015_c13f, 0xe)) goto l_0x1015_c13f; /* jz 0x1015c13f */
            ii(0x1015_c131, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c134, 5); calld(0x1007_6574, -0xe_5bc5);          /* call 0x10076574 */
            ii(0x1015_c139, 4); and(memb_a32[ds, eax + 0x69], -0x2 /* 0xfe */); /* and byte [eax+0x69], 0xfe */
            ii(0x1015_c13d, 2); jmpd(0x1015_c14b, 0xc); goto l_0x1015_c14b; /* jmp 0x1015c14b */
        l_0x1015_c13f:
            ii(0x1015_c13f, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c142, 5); calld(0x1007_6574, -0xe_5bd3);          /* call 0x10076574 */
            ii(0x1015_c147, 4); and(memb_a32[ds, eax + 0x69], -0x3 /* 0xfd */); /* and byte [eax+0x69], 0xfd */
        l_0x1015_c14b:
            ii(0x1015_c14b, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c14e, 5); calld(0x1007_6574, -0xe_5bdf);          /* call 0x10076574 */
            ii(0x1015_c153, 5); calld(0x1014_9fa8, -0x1_21b0);          /* call 0x10149fa8 */
        l_0x1015_c158:
            ii(0x1015_c158, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c15b, 4); test(memb_a32[ds, eax + 0x69], 0x20);   /* test byte [eax+0x69], 0x20 */
            ii(0x1015_c15f, 6); if(jzd(0x1015_c1f4, 0x8f)) goto l_0x1015_c1f4; /* jz 0x1015c1f4 */
            ii(0x1015_c165, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_c168, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_c16b, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_c16e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c171, 1); inc(eax);                               /* inc eax */
            ii(0x1015_c172, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c175, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c179, 5); calld(0x1007_5331, -0xe_6e4d);          /* call 0x10075331 */
            ii(0x1015_c17e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c180, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c183, 5); calld(0x1007_6630, -0xe_5b58);          /* call 0x10076630 */
            ii(0x1015_c188, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c18b, 5); calld(0x1007_6574, -0xe_5c1c);          /* call 0x10076574 */
            ii(0x1015_c190, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_c197, 2); if(jzd(0x1015_c1a7, 0xe)) goto l_0x1015_c1a7; /* jz 0x1015c1a7 */
            ii(0x1015_c199, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c19c, 5); calld(0x1007_6574, -0xe_5c2d);          /* call 0x10076574 */
            ii(0x1015_c1a1, 4); and(memb_a32[ds, eax + 0x69], -0x2 /* 0xfe */); /* and byte [eax+0x69], 0xfe */
            ii(0x1015_c1a5, 2); jmpd(0x1015_c1e7, 0x40); goto l_0x1015_c1e7; /* jmp 0x1015c1e7 */
        l_0x1015_c1a7:
            ii(0x1015_c1a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_c1aa, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1015_c1ad, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_c1b0, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1015_c1b4, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c1b8, 5); calld(0x1007_5331, -0xe_6e8c);          /* call 0x10075331 */
            ii(0x1015_c1bd, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_c1c0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c1c2, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c1c4, 5); calld(0x1007_6e00, -0xe_53c9);          /* call 0x10076e00 */
            ii(0x1015_c1c9, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c1cb, 2); if(jzd(0x1015_c1db, 0xe)) goto l_0x1015_c1db; /* jz 0x1015c1db */
            ii(0x1015_c1cd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c1d0, 5); calld(0x1007_6574, -0xe_5c61);          /* call 0x10076574 */
            ii(0x1015_c1d5, 4); and(memb_a32[ds, eax + 0x69], -0x3 /* 0xfd */); /* and byte [eax+0x69], 0xfd */
            ii(0x1015_c1d9, 2); jmpd(0x1015_c1e7, 0xc); goto l_0x1015_c1e7; /* jmp 0x1015c1e7 */
        l_0x1015_c1db:
            ii(0x1015_c1db, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c1de, 5); calld(0x1007_6574, -0xe_5c6f);          /* call 0x10076574 */
            ii(0x1015_c1e3, 4); and(memb_a32[ds, eax + 0x69], -0x2 /* 0xfe */); /* and byte [eax+0x69], 0xfe */
        l_0x1015_c1e7:
            ii(0x1015_c1e7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c1ea, 5); calld(0x1007_6574, -0xe_5c7b);          /* call 0x10076574 */
            ii(0x1015_c1ef, 5); calld(0x1014_9fa8, -0x1_224c);          /* call 0x10149fa8 */
        l_0x1015_c1f4:
            ii(0x1015_c1f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c1f7, 4); test(memb_a32[ds, eax + 0x69], 0x40);   /* test byte [eax+0x69], 0x40 */
            ii(0x1015_c1fb, 6); if(jzd(0x1015_c28e, 0x8d)) goto l_0x1015_c28e; /* jz 0x1015c28e */
            ii(0x1015_c201, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_c205, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c208, 1); dec(eax);                               /* dec eax */
            ii(0x1015_c209, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c20c, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c210, 5); calld(0x1007_5331, -0xe_6ee4);          /* call 0x10075331 */
            ii(0x1015_c215, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_c218, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c21a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c21c, 5); calld(0x1007_6630, -0xe_5bf1);          /* call 0x10076630 */
            ii(0x1015_c221, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c224, 5); calld(0x1007_6574, -0xe_5cb5);          /* call 0x10076574 */
            ii(0x1015_c229, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_c230, 2); if(jzd(0x1015_c240, 0xe)) goto l_0x1015_c240; /* jz 0x1015c240 */
            ii(0x1015_c232, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c235, 5); calld(0x1007_6574, -0xe_5cc6);          /* call 0x10076574 */
            ii(0x1015_c23a, 4); and(memb_a32[ds, eax + 0x69], -0x5 /* 0xfb */); /* and byte [eax+0x69], 0xfb */
            ii(0x1015_c23e, 2); jmpd(0x1015_c281, 0x41); goto l_0x1015_c281; /* jmp 0x1015c281 */
        l_0x1015_c240:
            ii(0x1015_c240, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_c243, 1); inc(eax);                               /* inc eax */
            ii(0x1015_c244, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_c247, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c24a, 1); dec(eax);                               /* dec eax */
            ii(0x1015_c24b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c24e, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c252, 5); calld(0x1007_5331, -0xe_6f26);          /* call 0x10075331 */
            ii(0x1015_c257, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_c25a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c25c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c25e, 5); calld(0x1007_6e00, -0xe_5463);          /* call 0x10076e00 */
            ii(0x1015_c263, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c265, 2); if(jzd(0x1015_c275, 0xe)) goto l_0x1015_c275; /* jz 0x1015c275 */
            ii(0x1015_c267, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c26a, 5); calld(0x1007_6574, -0xe_5cfb);          /* call 0x10076574 */
            ii(0x1015_c26f, 4); and(memb_a32[ds, eax + 0x69], -0x5 /* 0xfb */); /* and byte [eax+0x69], 0xfb */
            ii(0x1015_c273, 2); jmpd(0x1015_c281, 0xc); goto l_0x1015_c281; /* jmp 0x1015c281 */
        l_0x1015_c275:
            ii(0x1015_c275, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c278, 5); calld(0x1007_6574, -0xe_5d09);          /* call 0x10076574 */
            ii(0x1015_c27d, 4); and(memb_a32[ds, eax + 0x69], -0x9 /* 0xf7 */); /* and byte [eax+0x69], 0xf7 */
        l_0x1015_c281:
            ii(0x1015_c281, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c284, 5); calld(0x1007_6574, -0xe_5d15);          /* call 0x10076574 */
            ii(0x1015_c289, 5); calld(0x1014_9fa8, -0x1_22e6);          /* call 0x10149fa8 */
        l_0x1015_c28e:
            ii(0x1015_c28e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_c291, 4); test(memb_a32[ds, eax + 0x69], 0x80);   /* test byte [eax+0x69], 0x80 */
            ii(0x1015_c295, 6); if(jzd(0x1015_c326, 0x8b)) goto l_0x1015_c326; /* jz 0x1015c326 */
            ii(0x1015_c29b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_c29e, 1); inc(eax);                               /* inc eax */
            ii(0x1015_c29f, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1015_c2a2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c2a5, 1); dec(eax);                               /* dec eax */
            ii(0x1015_c2a6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c2a9, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c2ad, 5); calld(0x1007_5331, -0xe_6f81);          /* call 0x10075331 */
            ii(0x1015_c2b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c2b4, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c2b7, 5); calld(0x1007_6630, -0xe_5c8c);          /* call 0x10076630 */
            ii(0x1015_c2bc, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c2bf, 5); calld(0x1007_6574, -0xe_5d50);          /* call 0x10076574 */
            ii(0x1015_c2c4, 7); test(memd_a32[ds, eax + 0x12], 0x80_0008); /* test dword [eax+0x12], 0x800008 */
            ii(0x1015_c2cb, 2); if(jzd(0x1015_c2db, 0xe)) goto l_0x1015_c2db; /* jz 0x1015c2db */
            ii(0x1015_c2cd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c2d0, 5); calld(0x1007_6574, -0xe_5d61);          /* call 0x10076574 */
            ii(0x1015_c2d5, 4); and(memb_a32[ds, eax + 0x69], -0x5 /* 0xfb */); /* and byte [eax+0x69], 0xfb */
            ii(0x1015_c2d9, 2); jmpd(0x1015_c319, 0x3e); goto l_0x1015_c319; /* jmp 0x1015c319 */
        l_0x1015_c2db:
            ii(0x1015_c2db, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1015_c2df, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_c2e2, 1); dec(eax);                               /* dec eax */
            ii(0x1015_c2e3, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_c2e6, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1015_c2ea, 5); calld(0x1007_5331, -0xe_6fbe);          /* call 0x10075331 */
            ii(0x1015_c2ef, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1015_c2f2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_c2f4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_c2f6, 5); calld(0x1007_6e00, -0xe_54fb);          /* call 0x10076e00 */
            ii(0x1015_c2fb, 2); test(al, al);                           /* test al, al */
            ii(0x1015_c2fd, 2); if(jzd(0x1015_c30d, 0xe)) goto l_0x1015_c30d; /* jz 0x1015c30d */
            ii(0x1015_c2ff, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c302, 5); calld(0x1007_6574, -0xe_5d93);          /* call 0x10076574 */
            ii(0x1015_c307, 4); and(memb_a32[ds, eax + 0x69], -0x9 /* 0xf7 */); /* and byte [eax+0x69], 0xf7 */
            ii(0x1015_c30b, 2); jmpd(0x1015_c319, 0xc); goto l_0x1015_c319; /* jmp 0x1015c319 */
        l_0x1015_c30d:
            ii(0x1015_c30d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c310, 5); calld(0x1007_6574, -0xe_5da1);          /* call 0x10076574 */
            ii(0x1015_c315, 4); and(memb_a32[ds, eax + 0x69], -0x5 /* 0xfb */); /* and byte [eax+0x69], 0xfb */
        l_0x1015_c319:
            ii(0x1015_c319, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c31c, 5); calld(0x1007_6574, -0xe_5dad);          /* call 0x10076574 */
            ii(0x1015_c321, 5); calld(0x1014_9fa8, -0x1_237e);          /* call 0x10149fa8 */
        l_0x1015_c326:
            ii(0x1015_c326, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_c328, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1015_c32b, 5); calld(0x1007_5f2c, -0xe_6404);          /* call 0x10075f2c */
        l_0x1015_c330:
            ii(0x1015_c330, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_c332, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_c333, 1); popd(edi);                              /* pop edi */
            ii(0x1015_c334, 1); popd(esi);                              /* pop esi */
            ii(0x1015_c335, 1); popd(edx);                              /* pop edx */
            ii(0x1015_c336, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_c337, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_c338, 1); retd();                                 /* ret */
        }
    }
}
