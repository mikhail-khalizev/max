using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f758beb-fb82-48a4-868c-16b59c9145ae")]
        public void Method_1015_d2ce()
        {
            ii(0x1015_d2ce, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1015_d2d3, 5); calld(Definitions.sys_check_available_stack_size, 0x8a7a); /* call 0x10165d52 */
            ii(0x1015_d2d8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_d2d9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_d2da, 1); pushd(esi);                             /* push esi */
            ii(0x1015_d2db, 1); pushd(edi);                             /* push edi */
            ii(0x1015_d2dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_d2dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_d2df, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1015_d2e5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_d2e8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_d2eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d2ee, 5); cmp(memw_a32[ds, eax + 0x8], 0x37);     /* cmp word [eax+0x8], 0x37 */
            ii(0x1015_d2f3, 2); if(jzd(0x1015_d2ff, 0xa)) goto l_0x1015_d2ff; /* jz 0x1015d2ff */
            ii(0x1015_d2f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d2f8, 5); cmp(memw_a32[ds, eax + 0x8], 0x23);     /* cmp word [eax+0x8], 0x23 */
            ii(0x1015_d2fd, 2); if(jnzd(0x1015_d301, 0x2)) goto l_0x1015_d301; /* jnz 0x1015d301 */
        l_0x1015_d2ff:
            ii(0x1015_d2ff, 2); jmpd(0x1015_d30b, 0xa); goto l_0x1015_d30b; /* jmp 0x1015d30b */
        l_0x1015_d301:
            ii(0x1015_d301, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d304, 5); cmp(memw_a32[ds, eax + 0x8], 0x44);     /* cmp word [eax+0x8], 0x44 */
            ii(0x1015_d309, 2); if(jnzd(0x1015_d314, 0x9)) goto l_0x1015_d314; /* jnz 0x1015d314 */
        l_0x1015_d30b:
            ii(0x1015_d30b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d30e, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x1015_d312, 2); if(jzd(0x1015_d316, 0x2)) goto l_0x1015_d316; /* jz 0x1015d316 */
        l_0x1015_d314:
            ii(0x1015_d314, 2); jmpd(0x1015_d31f, 0x9); goto l_0x1015_d31f; /* jmp 0x1015d31f */
        l_0x1015_d316:
            ii(0x1015_d316, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d31a, 5); jmpd(0x1015_d681, 0x362); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d31f:
            ii(0x1015_d31f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d322, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1015_d325, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_d32a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_d32c, 2); if(jgd(0x1015_d337, 0x9)) goto l_0x1015_d337; /* jg 0x1015d337 */
            ii(0x1015_d32e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d332, 5); jmpd(0x1015_d681, 0x34a); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d337:
            ii(0x1015_d337, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d33a, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1015_d33e, 2); if(jnzd(0x1015_d349, 0x9)) goto l_0x1015_d349; /* jnz 0x1015d349 */
            ii(0x1015_d340, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d344, 5); jmpd(0x1015_d681, 0x338); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d349:
            ii(0x1015_d349, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d34c, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1015_d350, 2); if(jzd(0x1015_d35b, 0x9)) goto l_0x1015_d35b; /* jz 0x1015d35b */
            ii(0x1015_d352, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d355, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1b);    /* cmp byte [eax+0x3d], 0x1b */
            ii(0x1015_d359, 2); if(jnzd(0x1015_d35d, 0x2)) goto l_0x1015_d35d; /* jnz 0x1015d35d */
        l_0x1015_d35b:
            ii(0x1015_d35b, 2); jmpd(0x1015_d366, 0x9); goto l_0x1015_d366; /* jmp 0x1015d366 */
        l_0x1015_d35d:
            ii(0x1015_d35d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d360, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1e);    /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1015_d364, 2); if(jnzd(0x1015_d36f, 0x9)) goto l_0x1015_d36f; /* jnz 0x1015d36f */
        l_0x1015_d366:
            ii(0x1015_d366, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d369, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1015_d36d, 2); if(jnzd(0x1015_d371, 0x2)) goto l_0x1015_d371; /* jnz 0x1015d371 */
        l_0x1015_d36f:
            ii(0x1015_d36f, 2); jmpd(0x1015_d37a, 0x9); goto l_0x1015_d37a; /* jmp 0x1015d37a */
        l_0x1015_d371:
            ii(0x1015_d371, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d375, 5); jmpd(0x1015_d681, 0x307); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d37a:
            ii(0x1015_d37a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d37d, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1015_d381, 2); if(jnzd(0x1015_d38c, 0x9)) goto l_0x1015_d38c; /* jnz 0x1015d38c */
            ii(0x1015_d383, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d387, 5); jmpd(0x1015_d681, 0x2f5); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d38c:
            ii(0x1015_d38c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d38f, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1b);    /* cmp byte [eax+0x3e], 0x1b */
            ii(0x1015_d393, 2); if(jnzd(0x1015_d39e, 0x9)) goto l_0x1015_d39e; /* jnz 0x1015d39e */
            ii(0x1015_d395, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d399, 5); jmpd(0x1015_d681, 0x2e3); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d39e:
            ii(0x1015_d39e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d3a1, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_d3a4, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_d3a6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_d3a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d3ac, 5); calld(0x1007_6074, -0xe_733d);          /* call 0x10076074 */
            ii(0x1015_d3b1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_d3b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_d3b8, 2); if(jnzd(0x1015_d3c3, 0x9)) goto l_0x1015_d3c3; /* jnz 0x1015d3c3 */
            ii(0x1015_d3ba, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d3be, 5); jmpd(0x1015_d681, 0x2be); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d3c3:
            ii(0x1015_d3c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d3c6, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_d3cb, 2); if(jzd(0x1015_d3d7, 0xa)) goto l_0x1015_d3d7; /* jz 0x1015d3d7 */
            ii(0x1015_d3cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d3d0, 5); cmp(memw_a32[ds, eax + 0x8], 0x47);     /* cmp word [eax+0x8], 0x47 */
            ii(0x1015_d3d5, 2); if(jnzd(0x1015_d3ee, 0x17)) goto l_0x1015_d3ee; /* jnz 0x1015d3ee */
        l_0x1015_d3d7:
            ii(0x1015_d3d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d3da, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_d3dd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_d3df, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_d3e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d3e5, 5); calld(0x1007_6074, -0xe_7376);          /* call 0x10076074 */
            ii(0x1015_d3ea, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d3ec, 2); if(jzd(0x1015_d3f0, 0x2)) goto l_0x1015_d3f0; /* jz 0x1015d3f0 */
        l_0x1015_d3ee:
            ii(0x1015_d3ee, 2); jmpd(0x1015_d3f9, 0x9); goto l_0x1015_d3f9; /* jmp 0x1015d3f9 */
        l_0x1015_d3f0:
            ii(0x1015_d3f0, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d3f4, 5); jmpd(0x1015_d681, 0x288); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d3f9:
            ii(0x1015_d3f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d3fc, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_d3ff, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_d404, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_d40a, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x1015_d410, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_d415, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_d418, 2); if(jnzd(0x1015_d42d, 0x13)) goto l_0x1015_d42d; /* jnz 0x1015d42d */
            ii(0x1015_d41a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_d41d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d420, 5); calld(0x100a_9eea, -0xb_353b);          /* call 0x100a9eea */
            ii(0x1015_d425, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1015_d428, 5); jmpd(0x1015_d681, 0x254); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d42d:
            ii(0x1015_d42d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_d42f, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1015_d434, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_d436, 2); if(jzd(0x1015_d441, 0x9)) goto l_0x1015_d441; /* jz 0x1015d441 */
            ii(0x1015_d438, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d43b, 4); cmp(memb_a32[ds, eax + 0x3d], 0xc);     /* cmp byte [eax+0x3d], 0xc */
            ii(0x1015_d43f, 2); if(jnzd(0x1015_d44a, 0x9)) goto l_0x1015_d44a; /* jnz 0x1015d44a */
        l_0x1015_d441:
            ii(0x1015_d441, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_d445, 5); jmpd(0x1015_d681, 0x237); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d44a:
            ii(0x1015_d44a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d44d, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_d450, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_d455, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_d45b, 7); cmp(memb_a32[ds, eax + 0x101c_a491], 0); /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x1015_d462, 2); if(jzd(0x1015_d470, 0xc)) goto l_0x1015_d470; /* jz 0x1015d470 */
            ii(0x1015_d464, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_d466, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1015_d46b, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1015_d46e, 2); if(jzd(0x1015_d472, 0x2)) goto l_0x1015_d472; /* jz 0x1015d472 */
        l_0x1015_d470:
            ii(0x1015_d470, 2); jmpd(0x1015_d47b, 0x9); goto l_0x1015_d47b; /* jmp 0x1015d47b */
        l_0x1015_d472:
            ii(0x1015_d472, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_d476, 5); jmpd(0x1015_d681, 0x206); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d47b:
            ii(0x1015_d47b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d47e, 4); cmp(memb_a32[ds, eax + 0x50], 0);       /* cmp byte [eax+0x50], 0x0 */
            ii(0x1015_d482, 2); if(jnzd(0x1015_d48d, 0x9)) goto l_0x1015_d48d; /* jnz 0x1015d48d */
            ii(0x1015_d484, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d488, 5); jmpd(0x1015_d681, 0x1f4); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d48d:
            ii(0x1015_d48d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_d490, 4); cmp(memb_a32[ds, eax + 0x5b], 0);       /* cmp byte [eax+0x5b], 0x0 */
            ii(0x1015_d494, 2); if(jzd(0x1015_d49f, 0x9)) goto l_0x1015_d49f; /* jz 0x1015d49f */
            ii(0x1015_d496, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d49a, 5); jmpd(0x1015_d681, 0x1e2); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d49f:
            ii(0x1015_d49f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_d4a1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_d4a4, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_d4a7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_d4aa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_d4ac, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_d4af, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1015_d4b2, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_d4b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d4b8, 5); calld(0x1007_623c, -0xe_7281);          /* call 0x1007623c */
            ii(0x1015_d4bd, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1015_d4c1, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_d4c4, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1015_d4c9, 5); calld(0x1007_6338, -0xe_7196);          /* call 0x10076338 */
            ii(0x1015_d4ce, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d4d0, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d4d3, 5); calld(0x1007_64b8, -0xe_7020);          /* call 0x100764b8 */
            ii(0x1015_d4d8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_d4db, 4); imul(eax, memd_a32[ss, ebp - 0x18]);    /* imul eax, [ebp-0x18] */
            ii(0x1015_d4df, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_d4e2, 2); jmpd(0x1015_d4ec, 0x8); goto l_0x1015_d4ec; /* jmp 0x1015d4ec */
        l_0x1015_d4e4:
            ii(0x1015_d4e4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d4e7, 5); calld(0x1007_6bf8, -0xe_68f4);          /* call 0x10076bf8 */
        l_0x1015_d4ec:
            ii(0x1015_d4ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d4ee, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d4f1, 5); calld(0x1013_ad71, -0x2_2785);          /* call 0x1013ad71 */
            ii(0x1015_d4f6, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d4f8, 2); if(jzd(0x1015_d556, 0x5c)) goto l_0x1015_d556; /* jz 0x1015d556 */
            ii(0x1015_d4fa, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d4fd, 5); calld(0x1007_63a0, -0xe_7162);          /* call 0x100763a0 */
            ii(0x1015_d502, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d504, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_d507, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_d50b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_d50d, 2); if(jnzd(0x1015_d527, 0x18)) goto l_0x1015_d527; /* jnz 0x1015d527 */
            ii(0x1015_d50f, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d512, 5); calld(0x1007_63d4, -0xe_7143);          /* call 0x100763d4 */
            ii(0x1015_d517, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d519, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d51c, 5); calld(0x1007_0d01, -0xe_c820);          /* call 0x10070d01 */
            ii(0x1015_d521, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1015_d525, 2); if(jled(0x1015_d529, 0x2)) goto l_0x1015_d529; /* jle 0x1015d529 */
        l_0x1015_d527:
            ii(0x1015_d527, 2); jmpd(0x1015_d53f, 0x16); goto l_0x1015_d53f; /* jmp 0x1015d53f */
        l_0x1015_d529:
            ii(0x1015_d529, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d52c, 5); calld(0x1007_636c, -0xe_71c5);          /* call 0x1007636c */
            ii(0x1015_d531, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d533, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d536, 5); calld(0x1007_4bde, -0xe_895d);          /* call 0x10074bde */
            ii(0x1015_d53b, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d53d, 2); if(jnzd(0x1015_d541, 0x2)) goto l_0x1015_d541; /* jnz 0x1015d541 */
        l_0x1015_d53f:
            ii(0x1015_d53f, 2); jmpd(0x1015_d554, 0x13); goto l_0x1015_d554; /* jmp 0x1015d554 */
        l_0x1015_d541:
            ii(0x1015_d541, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_d545, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d547, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d54a, 5); calld(0x1007_5f6c, -0xe_75e3);          /* call 0x10075f6c */
            ii(0x1015_d54f, 5); jmpd(0x1015_d681, 0x12d); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d554:
            ii(0x1015_d554, 2); jmpd(0x1015_d4e4, -0x72); goto l_0x1015_d4e4; /* jmp 0x1015d4e4 */
        l_0x1015_d556:
            ii(0x1015_d556, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1015_d55b, 5); calld(0x1007_6338, -0xe_7228);          /* call 0x10076338 */
            ii(0x1015_d560, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1015_d563, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d565, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_d567, 5); calld(0x1007_643c, -0xe_7130);          /* call 0x1007643c */
            ii(0x1015_d56c, 2); jmpd(0x1015_d576, 0x8); goto l_0x1015_d576; /* jmp 0x1015d576 */
        l_0x1015_d56e:
            ii(0x1015_d56e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d571, 5); calld(0x1007_6bf8, -0xe_697e);          /* call 0x10076bf8 */
        l_0x1015_d576:
            ii(0x1015_d576, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d578, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d57b, 5); calld(0x1013_ad71, -0x2_280f);          /* call 0x1013ad71 */
            ii(0x1015_d580, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d582, 2); if(jzd(0x1015_d5e0, 0x5c)) goto l_0x1015_d5e0; /* jz 0x1015d5e0 */
            ii(0x1015_d584, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d587, 5); calld(0x1007_63a0, -0xe_71ec);          /* call 0x100763a0 */
            ii(0x1015_d58c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d58e, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_d591, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_d595, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_d597, 2); if(jnzd(0x1015_d5b1, 0x18)) goto l_0x1015_d5b1; /* jnz 0x1015d5b1 */
            ii(0x1015_d599, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d59c, 5); calld(0x1007_63d4, -0xe_71cd);          /* call 0x100763d4 */
            ii(0x1015_d5a1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d5a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d5a6, 5); calld(0x1007_0d01, -0xe_c8aa);          /* call 0x10070d01 */
            ii(0x1015_d5ab, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1015_d5af, 2); if(jled(0x1015_d5b3, 0x2)) goto l_0x1015_d5b3; /* jle 0x1015d5b3 */
        l_0x1015_d5b1:
            ii(0x1015_d5b1, 2); jmpd(0x1015_d5c9, 0x16); goto l_0x1015_d5c9; /* jmp 0x1015d5c9 */
        l_0x1015_d5b3:
            ii(0x1015_d5b3, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d5b6, 5); calld(0x1007_636c, -0xe_724f);          /* call 0x1007636c */
            ii(0x1015_d5bb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d5bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d5c0, 5); calld(0x1007_4bde, -0xe_89e7);          /* call 0x10074bde */
            ii(0x1015_d5c5, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d5c7, 2); if(jnzd(0x1015_d5cb, 0x2)) goto l_0x1015_d5cb; /* jnz 0x1015d5cb */
        l_0x1015_d5c9:
            ii(0x1015_d5c9, 2); jmpd(0x1015_d5de, 0x13); goto l_0x1015_d5de; /* jmp 0x1015d5de */
        l_0x1015_d5cb:
            ii(0x1015_d5cb, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_d5cf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d5d1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d5d4, 5); calld(0x1007_5f6c, -0xe_766d);          /* call 0x10075f6c */
            ii(0x1015_d5d9, 5); jmpd(0x1015_d681, 0xa3); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d5de:
            ii(0x1015_d5de, 2); jmpd(0x1015_d56e, -0x72); goto l_0x1015_d56e; /* jmp 0x1015d56e */
        l_0x1015_d5e0:
            ii(0x1015_d5e0, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1015_d5e5, 5); calld(0x1007_6338, -0xe_72b2);          /* call 0x10076338 */
            ii(0x1015_d5ea, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1015_d5ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d5ef, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_d5f1, 5); calld(0x1007_643c, -0xe_71ba);          /* call 0x1007643c */
            ii(0x1015_d5f6, 2); jmpd(0x1015_d600, 0x8); goto l_0x1015_d600; /* jmp 0x1015d600 */
        l_0x1015_d5f8:
            ii(0x1015_d5f8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d5fb, 5); calld(0x1007_6bf8, -0xe_6a08);          /* call 0x10076bf8 */
        l_0x1015_d600:
            ii(0x1015_d600, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d602, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d605, 5); calld(0x1013_ad71, -0x2_2899);          /* call 0x1013ad71 */
            ii(0x1015_d60a, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d60c, 2); if(jzd(0x1015_d667, 0x59)) goto l_0x1015_d667; /* jz 0x1015d667 */
            ii(0x1015_d60e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d611, 5); calld(0x1007_63a0, -0xe_7276);          /* call 0x100763a0 */
            ii(0x1015_d616, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d618, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1015_d61b, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1015_d61f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1015_d621, 2); if(jnzd(0x1015_d63b, 0x18)) goto l_0x1015_d63b; /* jnz 0x1015d63b */
            ii(0x1015_d623, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d626, 5); calld(0x1007_63d4, -0xe_7257);          /* call 0x100763d4 */
            ii(0x1015_d62b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d62d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d630, 5); calld(0x1007_0d01, -0xe_c934);          /* call 0x10070d01 */
            ii(0x1015_d635, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x1015_d639, 2); if(jled(0x1015_d63d, 0x2)) goto l_0x1015_d63d; /* jle 0x1015d63d */
        l_0x1015_d63b:
            ii(0x1015_d63b, 2); jmpd(0x1015_d653, 0x16); goto l_0x1015_d653; /* jmp 0x1015d653 */
        l_0x1015_d63d:
            ii(0x1015_d63d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d640, 5); calld(0x1007_636c, -0xe_72d9);          /* call 0x1007636c */
            ii(0x1015_d645, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_d647, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_d64a, 5); calld(0x1007_4bde, -0xe_8a71);          /* call 0x10074bde */
            ii(0x1015_d64f, 2); test(al, al);                           /* test al, al */
            ii(0x1015_d651, 2); if(jnzd(0x1015_d655, 0x2)) goto l_0x1015_d655; /* jnz 0x1015d655 */
        l_0x1015_d653:
            ii(0x1015_d653, 2); jmpd(0x1015_d665, 0x10); goto l_0x1015_d665; /* jmp 0x1015d665 */
        l_0x1015_d655:
            ii(0x1015_d655, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_d659, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d65b, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d65e, 5); calld(0x1007_5f6c, -0xe_76f7);          /* call 0x10075f6c */
            ii(0x1015_d663, 2); jmpd(0x1015_d681, 0x1c); goto l_0x1015_d681; /* jmp 0x1015d681 */
        l_0x1015_d665:
            ii(0x1015_d665, 2); jmpd(0x1015_d5f8, -0x6f); goto l_0x1015_d5f8; /* jmp 0x1015d5f8 */
        l_0x1015_d667:
            ii(0x1015_d667, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1015_d66b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_d66d, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1015_d670, 5); calld(0x1007_5f6c, -0xe_7709);          /* call 0x10075f6c */
            ii(0x1015_d675, 2); jmpd(0x1015_d681, 0xa); goto l_0x1015_d681; /* jmp 0x1015d681 */
        //    ii(0x1015_d677, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1015_d679, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
        //    ii(0x1015_d67c, 5); calld(0x1007_5f6c, -0xe_7715);          /* call 0x10075f6c */
        l_0x1015_d681:
            ii(0x1015_d681, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_d684, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_d686, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_d687, 1); popd(edi);                              /* pop edi */
            ii(0x1015_d688, 1); popd(esi);                              /* pop esi */
            ii(0x1015_d689, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_d68a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_d68b, 1); retd(); return;                         /* ret */
        }
    }
}
