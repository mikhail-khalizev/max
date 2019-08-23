using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_f003-19246d7e")]
        public void Method_1012_f003()
        {
            ii(0x1012_f003, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1012_f008, 5); calld(Definitions.sys_check_available_stack_size, 0x3_6d45); /* call 0x10165d52 */
            ii(0x1012_f00d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_f00e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_f00f, 1); pushd(edx);                             /* push edx */
            ii(0x1012_f010, 1); pushd(esi);                             /* push esi */
            ii(0x1012_f011, 1); pushd(edi);                             /* push edi */
            ii(0x1012_f012, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_f013, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_f015, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1012_f01b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_f01e, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1012_f022, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_f025, 5); calld(0x1007_64fc, -0xb_8b2e);          /* call 0x100764fc */
            ii(0x1012_f02a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_f02d, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1012_f031, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_f038, 5); mov(ebx, 0x5d);                         /* mov ebx, 0x5d */
            ii(0x1012_f03d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_f042, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f045, 3); add(eax, 0x40);                         /* add eax, 0x40 */
            ii(0x1012_f048, 5); calld(Definitions.sys_memset, 0x3_6d93); /* call 0x10165de0 */
            ii(0x1012_f04d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f050, 4); mov(memb_a32[ds, eax + 0x55], 0);       /* mov byte [eax+0x55], 0x0 */
            ii(0x1012_f054, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f057, 4); mov(memb_a32[ds, eax + 0x4c], 0);       /* mov byte [eax+0x4c], 0x0 */
            ii(0x1012_f05b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f05e, 4); mov(memb_a32[ds, eax + 0x66], 0);       /* mov byte [eax+0x66], 0x0 */
            ii(0x1012_f062, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f065, 4); mov(memb_a32[ds, eax + 0x61], 0);       /* mov byte [eax+0x61], 0x0 */
            ii(0x1012_f069, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f06c, 4); mov(memb_a32[ds, eax + 0x67], 0);       /* mov byte [eax+0x67], 0x0 */
            ii(0x1012_f070, 7); cmp(memb_a32[ds, 0x101c_61b0], 0);      /* cmp byte [0x101c61b0], 0x0 */
            ii(0x1012_f077, 2); if(jzd(0x1012_f0bc, 0x43)) goto l_0x1012_f0bc; /* jz 0x1012f0bc */
            ii(0x1012_f079, 5); mov(ebx, 0x5d);                         /* mov ebx, 0x5d */
            ii(0x1012_f07e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_f080, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f083, 3); add(eax, 0x40);                         /* add eax, 0x40 */
            ii(0x1012_f086, 5); calld(Definitions.sys_memset, 0x3_6d55); /* call 0x10165de0 */
            ii(0x1012_f08b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f08e, 4); mov(memb_a32[ds, eax + 0x71], 0x1);     /* mov byte [eax+0x71], 0x1 */
            ii(0x1012_f092, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f095, 4); mov(memb_a32[ds, eax + 0x7d], 0x1);     /* mov byte [eax+0x7d], 0x1 */
            ii(0x1012_f099, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f09c, 4); mov(memb_a32[ds, eax + 0x58], 0x1);     /* mov byte [eax+0x58], 0x1 */
            ii(0x1012_f0a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f0a3, 4); mov(memb_a32[ds, eax + 0x59], 0x1);     /* mov byte [eax+0x59], 0x1 */
            ii(0x1012_f0a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f0aa, 4); mov(memb_a32[ds, eax + 0x5b], 0x1);     /* mov byte [eax+0x5b], 0x1 */
            ii(0x1012_f0ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f0b1, 4); mov(memb_a32[ds, eax + 0x57], 0x1);     /* mov byte [eax+0x57], 0x1 */
            ii(0x1012_f0b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f0b8, 4); mov(memb_a32[ds, eax + 0x60], 0x1);     /* mov byte [eax+0x60], 0x1 */
        l_0x1012_f0bc:
            ii(0x1012_f0bc, 7); cmp(memb_a32[ds, 0x101c_61b1], 0);      /* cmp byte [0x101c61b1], 0x0 */
            ii(0x1012_f0c3, 2); if(jzd(0x1012_f111, 0x4c)) goto l_0x1012_f111; /* jz 0x1012f111 */
            ii(0x1012_f0c5, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_f0cc, 2); jmpd(0x1012_f0d4, 0x6); goto l_0x1012_f0d4; /* jmp 0x1012f0d4 */
        l_0x1012_f0ce:
            ii(0x1012_f0ce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_f0d1, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1012_f0d4:
            ii(0x1012_f0d4, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f0d8, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1012_f0db, 2); if(jged(0x1012_f111, 0x34)) goto l_0x1012_f111; /* jge 0x1012f111 */
            ii(0x1012_f0dd, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_f0e1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_f0e3, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_f0e8, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_f0ee, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1012_f0f3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_f0f5, 5); calld(0x100d_fd2c, -0x4_f3ce);          /* call 0x100dfd2c */
            ii(0x1012_f0fa, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1012_f0fd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_f100, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_f102, 2); if(jnzd(0x1012_f10f, 0xb)) goto l_0x1012_f10f; /* jnz 0x1012f10f */
            ii(0x1012_f104, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f108, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1012_f10b, 4); mov(memb_a32[ds, eax + 0x40], 0);       /* mov byte [eax+0x40], 0x0 */
        l_0x1012_f10f:
            ii(0x1012_f10f, 2); jmpd(0x1012_f0ce, -0x43); goto l_0x1012_f0ce; /* jmp 0x1012f0ce */
        l_0x1012_f111:
            ii(0x1012_f111, 7); cmp(memb_a32[ds, 0x101c_61b3], 0);      /* cmp byte [0x101c61b3], 0x0 */
            ii(0x1012_f118, 2); if(jzd(0x1012_f153, 0x39)) goto l_0x1012_f153; /* jz 0x1012f153 */
            ii(0x1012_f11a, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_f121, 2); jmpd(0x1012_f129, 0x6); goto l_0x1012_f129; /* jmp 0x1012f129 */
        l_0x1012_f123:
            ii(0x1012_f123, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_f126, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1012_f129:
            ii(0x1012_f129, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f12d, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1012_f130, 2); if(jged(0x1012_f153, 0x21)) goto l_0x1012_f153; /* jge 0x1012f153 */
            ii(0x1012_f132, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f136, 3); cmp(eax, 0x47);                         /* cmp eax, 0x47 */
            ii(0x1012_f139, 2); if(jzd(0x1012_f144, 0x9)) goto l_0x1012_f144; /* jz 0x1012f144 */
            ii(0x1012_f13b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f13f, 3); cmp(eax, 0x42);                         /* cmp eax, 0x42 */
            ii(0x1012_f142, 2); if(jnzd(0x1012_f146, 0x2)) goto l_0x1012_f146; /* jnz 0x1012f146 */
        l_0x1012_f144:
            ii(0x1012_f144, 2); jmpd(0x1012_f151, 0xb); goto l_0x1012_f151; /* jmp 0x1012f151 */
        l_0x1012_f146:
            ii(0x1012_f146, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f14a, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1012_f14d, 4); mov(memb_a32[ds, eax + 0x40], 0);       /* mov byte [eax+0x40], 0x0 */
        l_0x1012_f151:
            ii(0x1012_f151, 2); jmpd(0x1012_f123, -0x30); goto l_0x1012_f123; /* jmp 0x1012f123 */
        l_0x1012_f153:
            ii(0x1012_f153, 7); cmp(memb_a32[ds, 0x101b_b48c], 0);      /* cmp byte [0x101bb48c], 0x0 */
            ii(0x1012_f15a, 2); if(jzd(0x1012_f160, 0x4)) goto l_0x1012_f160; /* jz 0x1012f160 */
            ii(0x1012_f15c, 4); or(memd_a32[ss, ebp - 0x1c], 0x40);     /* or dword [ebp-0x1c], 0x40 */
        l_0x1012_f160:
            ii(0x1012_f160, 7); cmp(memb_a32[ds, 0x101b_b48d], 0);      /* cmp byte [0x101bb48d], 0x0 */
            ii(0x1012_f167, 2); if(jzd(0x1012_f170, 0x7)) goto l_0x1012_f170; /* jz 0x1012f170 */
            ii(0x1012_f169, 7); or(memd_a32[ss, ebp - 0x1c], 0x100);    /* or dword [ebp-0x1c], 0x100 */
        l_0x1012_f170:
            ii(0x1012_f170, 7); cmp(memb_a32[ds, 0x101b_b48e], 0);      /* cmp byte [0x101bb48e], 0x0 */
            ii(0x1012_f177, 2); if(jzd(0x1012_f180, 0x7)) goto l_0x1012_f180; /* jz 0x1012f180 */
            ii(0x1012_f179, 7); or(memd_a32[ss, ebp - 0x1c], 0x80);     /* or dword [ebp-0x1c], 0x80 */
        l_0x1012_f180:
            ii(0x1012_f180, 7); cmp(memb_a32[ds, 0x101b_b48f], 0);      /* cmp byte [0x101bb48f], 0x0 */
            ii(0x1012_f187, 2); if(jzd(0x1012_f190, 0x7)) goto l_0x1012_f190; /* jz 0x1012f190 */
            ii(0x1012_f189, 7); or(memd_a32[ss, ebp - 0x1c], 0x200);    /* or dword [ebp-0x1c], 0x200 */
        l_0x1012_f190:
            ii(0x1012_f190, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_f197, 2); jmpd(0x1012_f19f, 0x6); goto l_0x1012_f19f; /* jmp 0x1012f19f */
        l_0x1012_f199:
            ii(0x1012_f199, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_f19c, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1012_f19f:
            ii(0x1012_f19f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f1a3, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1012_f1a6, 2); if(jged(0x1012_f1e1, 0x39)) goto l_0x1012_f1e1; /* jge 0x1012f1e1 */
            ii(0x1012_f1a8, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f1ac, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_f1af, 6); mov(eax, memd_a32[ds, eax + 0x101c_81c0]); /* mov eax, [eax+0x101c81c0] */
            ii(0x1012_f1b5, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_f1b8, 7); test(memd_a32[ss, ebp - 0x20], 0x40_0000); /* test dword [ebp-0x20], 0x400000 */
            ii(0x1012_f1bf, 2); if(jzd(0x1012_f1ca, 0x9)) goto l_0x1012_f1ca; /* jz 0x1012f1ca */
            ii(0x1012_f1c1, 7); test(memd_a32[ss, ebp - 0x20], 0x1);    /* test dword [ebp-0x20], 0x1 */
            ii(0x1012_f1c8, 2); if(jzd(0x1012_f1cc, 0x2)) goto l_0x1012_f1cc; /* jz 0x1012f1cc */
        l_0x1012_f1ca:
            ii(0x1012_f1ca, 2); jmpd(0x1012_f1d4, 0x8); goto l_0x1012_f1d4; /* jmp 0x1012f1d4 */
        l_0x1012_f1cc:
            ii(0x1012_f1cc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_f1cf, 3); test(memd_a32[ss, ebp - 0x1c], eax);    /* test [ebp-0x1c], eax */
            ii(0x1012_f1d2, 2); if(jnzd(0x1012_f1df, 0xb)) goto l_0x1012_f1df; /* jnz 0x1012f1df */
        l_0x1012_f1d4:
            ii(0x1012_f1d4, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f1d8, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1012_f1db, 4); mov(memb_a32[ds, eax + 0x40], 0);       /* mov byte [eax+0x40], 0x0 */
        l_0x1012_f1df:
            ii(0x1012_f1df, 2); jmpd(0x1012_f199, -0x48); goto l_0x1012_f199; /* jmp 0x1012f199 */
        l_0x1012_f1e1:
            ii(0x1012_f1e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f1e4, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_f1e7, 5); calld(0x1013_b325, 0xc139);             /* call 0x1013b325 */
            ii(0x1012_f1ec, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x1012_f1f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f1f4, 5); calld(0x1012_eb0d, -0x6ec);             /* call 0x1012eb0d */
            ii(0x1012_f1f9, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x1012_f1fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f201, 5); calld(0x1012_eb0d, -0x6f9);             /* call 0x1012eb0d */
            ii(0x1012_f206, 5); mov(edx, 0x101c_819c);                  /* mov edx, 0x101c819c */
            ii(0x1012_f20b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f20e, 5); calld(0x1012_eb0d, -0x706);             /* call 0x1012eb0d */
            ii(0x1012_f213, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f216, 5); calld(0x1012_e160, -0x10bb);            /* call 0x1012e160 */
            ii(0x1012_f21b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_f21d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f220, 4); mov(memw_a32[ds, eax + 0x30], dx);      /* mov [eax+0x30], dx */
            ii(0x1012_f224, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f227, 3); mov(edx, memd_a32[ds, eax + 0x38]);     /* mov edx, [eax+0x38] */
            ii(0x1012_f22a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_f22d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f230, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_f233, 5); calld(Definitions.my_1_get_count, -0x8_3d60); /* call 0x100ab4d8 */
            ii(0x1012_f238, 1); cwde();                                 /* cwde */
            ii(0x1012_f239, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_f23b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_f23d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f240, 3); mov(eax, memd_a32[ds, eax + 0x2e]);     /* mov eax, [eax+0x2e] */
            ii(0x1012_f243, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_f246, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1012_f248, 2); if(jled(0x1012_f267, 0x1d)) goto l_0x1012_f267; /* jle 0x1012f267 */
            ii(0x1012_f24a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f24d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_f250, 5); calld(Definitions.my_1_get_count, -0x8_3d7d); /* call 0x100ab4d8 */
            ii(0x1012_f255, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_f257, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f25a, 4); mov(bx, memw_a32[ds, eax + 0x3a]);      /* mov bx, [eax+0x3a] */
            ii(0x1012_f25e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f261, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1012_f263, 4); mov(memw_a32[ds, eax + 0x30], dx);      /* mov [eax+0x30], dx */
        l_0x1012_f267:
            ii(0x1012_f267, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f26a, 3); mov(eax, memd_a32[ds, eax + 0x2e]);     /* mov eax, [eax+0x2e] */
            ii(0x1012_f26d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_f270, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_f272, 2); if(jged(0x1012_f27d, 0x9)) goto l_0x1012_f27d; /* jge 0x1012f27d */
            ii(0x1012_f274, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f277, 6); mov(memw_a32[ds, eax + 0x30], 0);       /* mov word [eax+0x30], 0x0 */
        l_0x1012_f27d:
            ii(0x1012_f27d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f280, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1012_f283, 5); calld(0x1009_caf8, -0x9_2790);          /* call 0x1009caf8 */
            ii(0x1012_f288, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_f28f, 2); jmpd(0x1012_f297, 0x6); goto l_0x1012_f297; /* jmp 0x1012f297 */
        l_0x1012_f291:
            ii(0x1012_f291, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_f294, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1012_f297:
            ii(0x1012_f297, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f29b, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x1012_f29e, 2); if(jged(0x1012_f302, 0x62)) goto l_0x1012_f302; /* jge 0x1012f302 */
            ii(0x1012_f2a0, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f2a4, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1012_f2a7, 4); cmp(memb_a32[ds, eax + 0x40], 0);       /* cmp byte [eax+0x40], 0x0 */
            ii(0x1012_f2ab, 2); if(jzd(0x1012_f300, 0x53)) goto l_0x1012_f300; /* jz 0x1012f300 */
            ii(0x1012_f2ad, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_f2b4, 2); jmpd(0x1012_f2bc, 0x6); goto l_0x1012_f2bc; /* jmp 0x1012f2bc */
        l_0x1012_f2b6:
            ii(0x1012_f2b6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_f2b9, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1012_f2bc:
            ii(0x1012_f2bc, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_f2c0, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_f2c3, 2); if(jged(0x1012_f2e3, 0x1e)) goto l_0x1012_f2e3; /* jge 0x1012f2e3 */
            ii(0x1012_f2c5, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_f2c9, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1012_f2cf, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_f2d3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_f2d5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_f2d7, 8); cmp(memw_a32[ds, eax + 0x101c_a5e9], 0); /* cmp word [eax+0x101ca5e9], 0x0 */
            ii(0x1012_f2df, 2); if(jnzd(0x1012_f2e3, 0x2)) goto l_0x1012_f2e3; /* jnz 0x1012f2e3 */
            ii(0x1012_f2e1, 2); jmpd(0x1012_f2b6, -0x2d); goto l_0x1012_f2b6; /* jmp 0x1012f2b6 */
        l_0x1012_f2e3:
            ii(0x1012_f2e3, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_f2e7, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_f2ea, 2); if(jged(0x1012_f300, 0x14)) goto l_0x1012_f300; /* jge 0x1012f300 */
            ii(0x1012_f2ec, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_f2ef, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1012_f2f2, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1012_f2f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f2f8, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1012_f2fb, 5); calld(0x1008_b2a8, -0xa_4058);          /* call 0x1008b2a8 */
        l_0x1012_f300:
            ii(0x1012_f300, 2); jmpd(0x1012_f291, -0x71); goto l_0x1012_f291; /* jmp 0x1012f291 */
        l_0x1012_f302:
            ii(0x1012_f302, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_f305, 6); mov(memw_a32[ds, eax + 0x32], 0);       /* mov word [eax+0x32], 0x0 */
            ii(0x1012_f30b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_f30d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1012_f310, 5); calld(0x1007_5f6c, -0xb_93a9);          /* call 0x10075f6c */
            ii(0x1012_f315, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_f317, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_f318, 1); popd(edi);                              /* pop edi */
            ii(0x1012_f319, 1); popd(esi);                              /* pop esi */
            ii(0x1012_f31a, 1); popd(edx);                              /* pop edx */
            ii(0x1012_f31b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_f31c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_f31d, 1); retd();                                 /* ret */
        }
    }
}
