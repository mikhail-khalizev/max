using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_3211-e4912d67")]
        public void Method_1011_3211()
        {
            ii(0x1011_3211, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1011_3216, 5); calld(Definitions.sys_check_available_stack_size, 0x5_2b37); /* call 0x10165d52 */
            ii(0x1011_321b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_321c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_321d, 1); pushd(edx);                             /* push edx */
            ii(0x1011_321e, 1); pushd(esi);                             /* push esi */
            ii(0x1011_321f, 1); pushd(edi);                             /* push edi */
            ii(0x1011_3220, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_3221, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_3223, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_3229, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_322c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_322f, 7); cmp(memb_a32[ds, eax + 0x51e], 0);      /* cmp byte [eax+0x51e], 0x0 */
            ii(0x1011_3236, 6); if(jzd(0x1011_32b4, 0x78)) goto l_0x1011_32b4; /* jz 0x101132b4 */
            ii(0x1011_323c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_323f, 7); mov(memb_a32[ds, eax + 0x51e], 0);      /* mov byte [eax+0x51e], 0x0 */
            ii(0x1011_3246, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x1011_324d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3250, 7); cmp(memb_a32[ds, eax + 0x51f], 0);      /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_3257, 2); if(jzd(0x1011_3281, 0x28)) goto l_0x1011_3281; /* jz 0x10113281 */
        l_0x1011_3259:
            ii(0x1011_3259, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1011_325c, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_3261, 2); if(jzd(0x1011_3271, 0xe)) goto l_0x1011_3271; /* jz 0x10113271 */
            ii(0x1011_3263, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_3267, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_326a, 5); calld(0x1011_3129, -0x146);             /* call 0x10113129 */
            ii(0x1011_326f, 2); jmpd(0x1011_3259, -0x18); goto l_0x1011_3259; /* jmp 0x10113259 */
        l_0x1011_3271:
            ii(0x1011_3271, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3274, 4); mov(memb_a32[ds, eax + 0xf], 0);        /* mov byte [eax+0xf], 0x0 */
            ii(0x1011_3278, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_327b, 4); mov(memb_a32[ds, eax + 0x11], 0xff);    /* mov byte [eax+0x11], 0xff */
            ii(0x1011_327f, 2); jmpd(0x1011_32b4, 0x33); goto l_0x1011_32b4; /* jmp 0x101132b4 */
        l_0x1011_3281:
            ii(0x1011_3281, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1011_3284, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1011_3289, 2); if(jzd(0x1011_32b4, 0x29)) goto l_0x1011_32b4; /* jz 0x101132b4 */
            ii(0x1011_328b, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_328f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3291, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3294, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_329a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_329d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_329f, 2); if(jnzd(0x1011_32b2, 0x11)) goto l_0x1011_32b2; /* jnz 0x101132b2 */
            ii(0x1011_32a1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_32a5, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_32a8, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_32ab, 7); mov(memb_a32[ds, eax + 0x338], 0);      /* mov byte [eax+0x338], 0x0 */
        l_0x1011_32b2:
            ii(0x1011_32b2, 2); jmpd(0x1011_3281, -0x33); goto l_0x1011_3281; /* jmp 0x10113281 */
        l_0x1011_32b4:
            ii(0x1011_32b4, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1011_32bb, 2); jmpd(0x1011_32c3, 0x6); goto l_0x1011_32c3; /* jmp 0x101132c3 */
        l_0x1011_32bd:
            ii(0x1011_32bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_32c0, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
        l_0x1011_32c3:
            ii(0x1011_32c3, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_32c7, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_32ca, 6); if(jged(0x1011_3486, 0x1b6)) goto l_0x1011_3486; /* jge 0x10113486 */
            ii(0x1011_32d0, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_32d3, 2); add(al, 0xd);                           /* add al, 0xd */
            ii(0x1011_32d5, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1011_32d8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_32db, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_32dd, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_32e1, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_32e4, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_32e7, 6); mov(eax, memd_a32[ds, eax + 0x5a9]);    /* mov eax, [eax+0x5a9] */
            ii(0x1011_32ed, 5); calld(0x100d_7f6c, -0x3_b386);          /* call 0x100d7f6c */
            ii(0x1011_32f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_32f5, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_32f7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_32fb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_32fe, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3301, 6); mov(eax, memd_a32[ds, eax + 0x5c1]);    /* mov eax, [eax+0x5c1] */
            ii(0x1011_3307, 5); calld(0x100d_7f6c, -0x3_b3a0);          /* call 0x100d7f6c */
            ii(0x1011_330c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_330f, 7); cmp(memb_a32[ds, eax + 0x51f], 0);      /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_3316, 2); if(jzd(0x1011_3331, 0x19)) goto l_0x1011_3331; /* jz 0x10113331 */
            ii(0x1011_3318, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_331c, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_331f, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3322, 6); mov(al, memb_a32[ds, eax + 0x520]);     /* mov al, [eax+0x520] */
            ii(0x1011_3328, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_332d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_332f, 2); if(jzd(0x1011_3333, 0x2)) goto l_0x1011_3333; /* jz 0x10113333 */
        l_0x1011_3331:
            ii(0x1011_3331, 2); jmpd(0x1011_338a, 0x57); goto l_0x1011_338a; /* jmp 0x1011338a */
        l_0x1011_3333:
            ii(0x1011_3333, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3337, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_333a, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_333d, 4); cmp(memd_a32[ds, eax + 0x16], 0);       /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_3341, 2); if(jzd(0x1011_3385, 0x42)) goto l_0x1011_3385; /* jz 0x10113385 */
            ii(0x1011_3343, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3347, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_334a, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_334d, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_3350, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_3353, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1011_3357, 2); if(jzd(0x1011_336d, 0x14)) goto l_0x1011_336d; /* jz 0x1011336d */
            ii(0x1011_3359, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_335b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_335e, 5); calld(Definitions.my_dtor_d2, -0x4_4e2b); /* call 0x100ce538 */
            ii(0x1011_3363, 5); calld(Definitions.sys_delete, 0x5_2bfc); /* call 0x10165f64 */
            ii(0x1011_3368, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_336b, 2); jmpd(0x1011_3374, 0x7); goto l_0x1011_3374; /* jmp 0x10113374 */
        l_0x1011_336d:
            ii(0x1011_336d, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1011_3374:
            ii(0x1011_3374, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3378, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_337b, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_337e, 7); mov(memd_a32[ds, eax + 0x16], 0);       /* mov dword [eax+0x16], 0x0 */
        l_0x1011_3385:
            ii(0x1011_3385, 5); jmpd(0x1011_3481, 0xf7); goto l_0x1011_3481; /* jmp 0x10113481 */
        l_0x1011_338a:
            ii(0x1011_338a, 5); calld(0x1011_5318, 0x1f89);             /* call 0x10115318 */
            ii(0x1011_338f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_3394, 1); pushd(eax);                             /* push eax */
            ii(0x1011_3395, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_3397, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1011_339c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_33a0, 3); add(edx, 0x3);                          /* add edx, 0x3 */
            ii(0x1011_33a3, 3); imul(edx, edx, 0x14);                   /* imul edx, edx, 0x14 */
            ii(0x1011_33a6, 5); mov(eax, 0x101b_9d8c);                  /* mov eax, 0x101b9d8c */
            ii(0x1011_33ab, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_33ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_33b0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_33b2, 5); calld(0x1010_8a05, -0xa9b2);            /* call 0x10108a05 */
            ii(0x1011_33b7, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_33bb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_33be, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_33c1, 4); cmp(memd_a32[ds, eax + 0x16], 0);       /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_33c5, 2); if(jnzd(0x1011_33d3, 0xc)) goto l_0x1011_33d3; /* jnz 0x101133d3 */
            ii(0x1011_33c7, 4); movsx(edx, memb_a32[ss, ebp - 0xc]);    /* movsx edx, byte [ebp-0xc] */
            ii(0x1011_33cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_33ce, 5); calld(0x1011_241a, -0xfb9);             /* call 0x1011241a */
        l_0x1011_33d3:
            ii(0x1011_33d3, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_33d7, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_33d9, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_33dc, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_33e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_33e5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_33e7, 2); if(jnzd(0x1011_3423, 0x3a)) goto l_0x1011_3423; /* jnz 0x10113423 */
            ii(0x1011_33e9, 5); calld(0x100d_51e4, -0x3_e20a);          /* call 0x100d51e4 */
            ii(0x1011_33ee, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_33f0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_33f2, 5); calld(0x100d_5204, -0x3_e1f3);          /* call 0x100d5204 */
            ii(0x1011_33f7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_33f9, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_33fb, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_33ff, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3402, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3405, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_3408, 5); calld(0x100c_fa7c, -0x4_3991);          /* call 0x100cfa7c */
            ii(0x1011_340d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_340f, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3413, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3416, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3419, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_341c, 5); calld(0x100c_fb73, -0x4_38ae);          /* call 0x100cfb73 */
            ii(0x1011_3421, 2); jmpd(0x1011_3481, 0x5e); goto l_0x1011_3481; /* jmp 0x10113481 */
        l_0x1011_3423:
            ii(0x1011_3423, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_3427, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3429, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_342c, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_3432, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_3435, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_3438, 2); if(jld(0x1011_3451, 0x17)) goto l_0x1011_3451; /* jl 0x10113451 */
            ii(0x1011_343a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1011_343e, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3440, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3443, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_3449, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_344c, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_344f, 2); if(jled(0x1011_3453, 0x2)) goto l_0x1011_3453; /* jle 0x10113453 */
        l_0x1011_3451:
            ii(0x1011_3451, 2); jmpd(0x1011_3481, 0x2e); goto l_0x1011_3481; /* jmp 0x10113481 */
        l_0x1011_3453:
            ii(0x1011_3453, 5); mov(edx, 0x30c);                        /* mov edx, 0x30c */
            ii(0x1011_3458, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_345c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_345f, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3462, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_3465, 5); calld(0x100c_f211, -0x4_4259);          /* call 0x100cf211 */
            ii(0x1011_346a, 5); mov(edx, 0x30c);                        /* mov edx, 0x30c */
            ii(0x1011_346f, 4); movsx(eax, memb_a32[ss, ebp - 0xc]);    /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3473, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_3476, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3479, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_347c, 5); calld(0x100c_f363, -0x4_411e);          /* call 0x100cf363 */
        l_0x1011_3481:
            ii(0x1011_3481, 5); jmpd(0x1011_32bd, -0x1c9); goto l_0x1011_32bd; /* jmp 0x101132bd */
        l_0x1011_3486:
            ii(0x1011_3486, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3489, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_348b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_348e, 6); mov(eax, memd_a32[ds, eax + 0x5b9]);    /* mov eax, [eax+0x5b9] */
            ii(0x1011_3494, 5); calld(0x100d_7f6c, -0x3_b52d);          /* call 0x100d7f6c */
            ii(0x1011_3499, 5); calld(0x1011_5318, 0x1e7a);             /* call 0x10115318 */
            ii(0x1011_349e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_34a3, 1); pushd(eax);                             /* push eax */
            ii(0x1011_34a4, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1011_34a9, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x1011_34ae, 5); mov(edx, 0x101b_9e18);                  /* mov edx, 0x101b9e18 */
            ii(0x1011_34b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_34b6, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_34b8, 5); calld(0x1010_8a05, -0xaab8);            /* call 0x10108a05 */
            ii(0x1011_34bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_34c0, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_34c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_34c5, 6); mov(eax, memd_a32[ds, eax + 0x5bd]);    /* mov eax, [eax+0x5bd] */
            ii(0x1011_34cb, 5); calld(0x100d_7f6c, -0x3_b564);          /* call 0x100d7f6c */
            ii(0x1011_34d0, 5); calld(0x1011_5318, 0x1e43);             /* call 0x10115318 */
            ii(0x1011_34d5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_34da, 1); pushd(eax);                             /* push eax */
            ii(0x1011_34db, 5); calld(0x1011_5338, 0x1e58);             /* call 0x10115338 */
            ii(0x1011_34e0, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_34e2, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_34e4, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1011_34e9, 5); mov(edx, 0x101b_9e2c);                  /* mov edx, 0x101b9e2c */
            ii(0x1011_34ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_34f1, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_34f3, 5); calld(0x1010_8a05, -0xaaf3);            /* call 0x10108a05 */
            ii(0x1011_34f8, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_34fd, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x1011_3502, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3505, 5); calld(0x1011_285d, -0xcad);             /* call 0x1011285d */
            ii(0x1011_350a, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_350f, 5); mov(edx, 0x12);                         /* mov edx, 0x12 */
            ii(0x1011_3514, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_3517, 5); calld(0x1011_285d, -0xcbf);             /* call 0x1011285d */
            ii(0x1011_351c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_351e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_351f, 1); popd(edi);                              /* pop edi */
            ii(0x1011_3520, 1); popd(esi);                              /* pop esi */
            ii(0x1011_3521, 1); popd(edx);                              /* pop edx */
            ii(0x1011_3522, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_3523, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_3524, 1); retd(); return;                         /* ret */
        }
    }
}
