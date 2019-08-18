using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("96041e53-0a75-43bc-9f92-bac9a69cdac6")]
        public void Method_100f_e750()
        {
            ii(0x100f_e750, 5); pushd(0x6c);                            /* push 0x6c */
            ii(0x100f_e755, 5); calld(Definitions.sys_check_available_stack_size, 0x6_75f8); /* call 0x10165d52 */
            ii(0x100f_e75a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_e75b, 1); pushd(esi);                             /* push esi */
            ii(0x100f_e75c, 1); pushd(edi);                             /* push edi */
            ii(0x100f_e75d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_e75e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_e760, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x100f_e766, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_e769, 3); mov(memb_a32[ss, ebp - 0x8], dl);       /* mov [ebp-0x8], dl */
            ii(0x100f_e76c, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100f_e76f, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100f_e772, 5); mov(memb_a32[ds, 0x101c_37c8], al);     /* mov [0x101c37c8], al */
            ii(0x100f_e777, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e779, 5); calld(0x100f_fa70, 0x12f2);             /* call 0x100ffa70 */
            ii(0x100f_e77e, 4); cmp(memb_a32[ss, ebp - 0x8], 0xa);      /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e782, 2); if(jnzd(0x100f_e7aa, 0x26)) goto l_0x100f_e7aa; /* jnz 0x100fe7aa */
            ii(0x100f_e784, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_e789, 5); calld(0x1007_5fdc, -0x8_87b2);          /* call 0x10075fdc */
            ii(0x100f_e78e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e791, 5); mov(al, memb_a32[ds, 0x101c_391f]);     /* mov al, [0x101c391f] */
            ii(0x100f_e796, 5); mov(memb_a32[ds, 0x101c_391e], al);     /* mov [0x101c391e], al */
            ii(0x100f_e79b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e79d, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_e7a2, 1); cwde();                                 /* cwde */
            ii(0x100f_e7a3, 5); calld(0x100f_3800, -0xafa8);            /* call 0x100f3800 */
            ii(0x100f_e7a8, 2); jmpd(0x100f_e7be, 0x14); goto l_0x100f_e7be; /* jmp 0x100fe7be */
        l_0x100f_e7aa:
            ii(0x100f_e7aa, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x100f_e7af, 5); calld(0x1007_5fdc, -0x8_87d8);          /* call 0x10075fdc */
            ii(0x100f_e7b4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e7b7, 7); mov(memb_a32[ds, 0x101c_391e], 0xb);    /* mov byte [0x101c391e], 0xb */
        l_0x100f_e7be:
            ii(0x100f_e7be, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_e7c2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_e7c4, 2); if(jnzd(0x100f_e7e3, 0x1d)) goto l_0x100f_e7e3; /* jnz 0x100fe7e3 */
            ii(0x100f_e7c6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e7c8, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_e7cd, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_e7d3, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_e7d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_e7de, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100f_e7e1, 2); if(jzd(0x100f_e7e5, 0x2)) goto l_0x100f_e7e5; /* jz 0x100fe7e5 */
        l_0x100f_e7e3:
            ii(0x100f_e7e3, 2); jmpd(0x100f_e7ec, 0x7); goto l_0x100f_e7ec; /* jmp 0x100fe7ec */
        l_0x100f_e7e5:
            ii(0x100f_e7e5, 7); mov(memd_a32[ss, ebp - 0x10], 0x2d);    /* mov dword [ebp-0x10], 0x2d */
        l_0x100f_e7ec:
            ii(0x100f_e7ec, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e7f0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_e7f6, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_e7fc, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100f_e7ff, 5); if(jmpd_func(0x100f_e90c, 0x108)) return; /* jmp 0x100fe90c */
            ii(0x100f_e804, 7); mov(memb_a32[ds, 0x101c_391e], 0x9);    /* mov byte [0x101c391e], 0x9 */
            ii(0x100f_e80b, 5); if(jmpd_func(0x100f_ea24, 0x214)) return; /* jmp 0x100fea24 */
            ii(0x100f_e810, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e815, 5); calld(0x100f_4fa2, -0x9878);            /* call 0x100f4fa2 */
            ii(0x100f_e81a, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_e81e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e820, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_e825, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_e827, 2); if(jzd(0x100f_e85f, 0x36)) goto l_0x100f_e85f; /* jz 0x100fe85f */
            ii(0x100f_e829, 7); cmp(memb_a32[ds, 0x101c_388b], 0);      /* cmp byte [0x101c388b], 0x0 */
            ii(0x100f_e830, 2); if(jzd(0x100f_e83b, 0x9)) goto l_0x100f_e83b; /* jz 0x100fe83b */
            ii(0x100f_e832, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e836, 5); calld(0x100f_e1cd, -0x66e);             /* call 0x100fe1cd */
        l_0x100f_e83b:
            ii(0x100f_e83b, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100f_e83e, 5); mov(memb_a32[ds, 0x101c_37da], al);     /* mov [0x101c37da], al */
            ii(0x100f_e843, 5); calld(0x1007_6054, -0x8_87f4);          /* call 0x10076054 */
            ii(0x100f_e848, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e84a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_e84c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e84e, 5); mov(al, memb_a32[ds, 0x101c_3920]);     /* mov al, [0x101c3920] */
            ii(0x100f_e853, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_e856, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e85a, 5); calld(0x1007_1d59, -0x8_cb06);          /* call 0x10071d59 */
        l_0x100f_e85f:
            ii(0x100f_e85f, 4); cmp(memb_a32[ss, ebp - 0x8], 0xa);      /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e863, 2); if(jzd(0x100f_e8a2, 0x3d)) goto l_0x100f_e8a2; /* jz 0x100fe8a2 */
            ii(0x100f_e865, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e869, 5); calld(0x100f_2ec7, -0xb9a7);            /* call 0x100f2ec7 */
            ii(0x100f_e86e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e870, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e875, 5); calld(0x1013_ad71, 0x3_c4f7);           /* call 0x1013ad71 */
            ii(0x100f_e87a, 2); test(al, al);                           /* test al, al */
            ii(0x100f_e87c, 2); if(jzd(0x100f_e88f, 0x11)) goto l_0x100f_e88f; /* jz 0x100fe88f */
            ii(0x100f_e87e, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e883, 5); calld(0x1007_6600, -0x8_8288);          /* call 0x10076600 */
            ii(0x100f_e888, 5); calld(0x1010_094d, 0x20c0);             /* call 0x1010094d */
            ii(0x100f_e88d, 2); jmpd(0x100f_e8a2, 0x13); goto l_0x100f_e8a2; /* jmp 0x100fe8a2 */
        l_0x100f_e88f:
            ii(0x100f_e88f, 7); cmp(memd_a32[ds, 0x101c_37dc], 0x1);    /* cmp dword [0x101c37dc], 0x1 */
            ii(0x100f_e896, 2); if(jnzd(0x100f_e8a2, 0xa)) goto l_0x100f_e8a2; /* jnz 0x100fe8a2 */
            ii(0x100f_e898, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e89d, 5); calld(0x1010_1374, 0x2ad2);             /* call 0x10101374 */
        l_0x100f_e8a2:
            ii(0x100f_e8a2, 5); if(jmpd_func(0x100f_e927, 0x80)) return; /* jmp 0x100fe927 */
            ii(0x100f_e8a7, 4); cmp(memb_a32[ss, ebp - 0x8], 0xa);      /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e8ab, 2); if(jzd(0x100f_e8d3, 0x26)) goto l_0x100f_e8d3; /* jz 0x100fe8d3 */
            ii(0x100f_e8ad, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e8b1, 5); calld(0x100f_2ec7, -0xb9ef);            /* call 0x100f2ec7 */
            ii(0x100f_e8b6, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x100f_e8bb, 5); calld(0x1007_5fdc, -0x8_88e4);          /* call 0x10075fdc */
            ii(0x100f_e8c0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_e8c3, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_e8c7, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x100f_e8ca, 2); if(jged(0x100f_e8d3, 0x7)) goto l_0x100f_e8d3; /* jge 0x100fe8d3 */
            ii(0x100f_e8cc, 7); mov(memd_a32[ss, ebp - 0x10], 0x2d);    /* mov dword [ebp-0x10], 0x2d */
        l_0x100f_e8d3:
            ii(0x100f_e8d3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e8d7, 5); calld(0x100a_8a8d, -0x5_5e4f);          /* call 0x100a8a8d */
            ii(0x100f_e8dc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e8de, 5); calld(0x100f_4fa2, -0x9941);            /* call 0x100f4fa2 */
            ii(0x100f_e8e3, 2); if(jmpd_func(0x100f_e927, 0x42)) return; /* jmp 0x100fe927 */
            ii(0x100f_e8e5, 4); cmp(memb_a32[ss, ebp - 0x8], 0xa);      /* cmp byte [ebp-0x8], 0xa */
            ii(0x100f_e8e9, 2); if(jzd(0x100f_e8f4, 0x9)) goto l_0x100f_e8f4; /* jz 0x100fe8f4 */
            ii(0x100f_e8eb, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100f_e8ef, 5); calld(0x100f_2ec7, -0xba2d);            /* call 0x100f2ec7 */
        l_0x100f_e8f4:
            ii(0x100f_e8f4, 2); if(jmpd_func(0x100f_e927, 0x31)) return; /* jmp 0x100fe927 */
        }
    }
}
