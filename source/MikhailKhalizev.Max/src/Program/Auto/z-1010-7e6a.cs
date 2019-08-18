using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f47f482-58a2-4015-b9c8-e047241eb112")]
        public void Method_1010_7e6a()
        {
            ii(0x1010_7e6a, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1010_7e6f, 5); calld(Definitions.sys_check_available_stack_size, 0x5_dede); /* call 0x10165d52 */
            ii(0x1010_7e74, 1); pushd(esi);                             /* push esi */
            ii(0x1010_7e75, 1); pushd(edi);                             /* push edi */
            ii(0x1010_7e76, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_7e77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7e79, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1010_7e7f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_7e82, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1010_7e85, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1010_7e88, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1010_7e8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_7e8e, 5); calld(0x1010_6f3f, -0xf54);             /* call 0x10106f3f */
            ii(0x1010_7e93, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_7e96, 7); cmp(memd_a32[ss, ebp - 0xc], 0x226);    /* cmp dword [ebp-0xc], 0x226 */
            ii(0x1010_7e9d, 2); if(jbd(0x1010_7ea9, 0xa)) goto l_0x1010_7ea9; /* jb 0x10107ea9 */
            ii(0x1010_7e9f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_7ea4, 5); calld(Definitions.sys_exit, 0x6_47b6);  /* call 0x1016c65f */
        l_0x1010_7ea9:
            ii(0x1010_7ea9, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7eae, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7eb1, 6); imul(edx, eax, 0x276);                  /* imul edx, eax, 0x276 */
            ii(0x1010_7eb7, 5); mov(eax, memd_a32[ds, 0x101c_4dac]);    /* mov eax, [0x101c4dac] */
            ii(0x1010_7ebc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7ebe, 4); cmp(memb_a32[ds, eax + 0x8], 0);        /* cmp byte [eax+0x8], 0x0 */
            ii(0x1010_7ec2, 2); if(jnzd(0x1010_7ea9, -0x1b)) goto l_0x1010_7ea9; /* jnz 0x10107ea9 */
            ii(0x1010_7ec4, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7ec9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7ecc, 6); imul(edx, eax, 0x276);                  /* imul edx, eax, 0x276 */
            ii(0x1010_7ed2, 5); mov(eax, memd_a32[ds, 0x101c_4dac]);    /* mov eax, [0x101c4dac] */
            ii(0x1010_7ed7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7ed9, 4); cmp(memb_a32[ds, eax + 0x9], 0);        /* cmp byte [eax+0x9], 0x0 */
            ii(0x1010_7edd, 2); if(jzd(0x1010_7ee9, 0xa)) goto l_0x1010_7ee9; /* jz 0x10107ee9 */
            ii(0x1010_7edf, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_7ee4, 5); calld(Definitions.sys_exit, 0x6_4776);  /* call 0x1016c65f */
        l_0x1010_7ee9:
            ii(0x1010_7ee9, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_7eee, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_7ef1, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7ef6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7ef9, 6); imul(ecx, eax, 0x276);                  /* imul ecx, eax, 0x276 */
            ii(0x1010_7eff, 5); mov(eax, memd_a32[ds, 0x101c_4dac]);    /* mov eax, [0x101c4dac] */
            ii(0x1010_7f04, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_7f06, 3); add(eax, 0x34);                         /* add eax, 0x34 */
            ii(0x1010_7f09, 5); calld(Definitions.sys_memcpy, 0x5_df3d); /* call 0x10165e4b */
            ii(0x1010_7f0e, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_7f13, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_7f16, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7f1b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7f1e, 6); imul(eax, eax, 0x276);                  /* imul eax, eax, 0x276 */
            ii(0x1010_7f24, 6); mov(ecx, memd_a32[ds, 0x101c_4dac]);    /* mov ecx, [0x101c4dac] */
            ii(0x1010_7f2a, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_7f2c, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1010_7f2f, 5); calld(Definitions.sys_memcpy, 0x5_df17); /* call 0x10165e4b */
            ii(0x1010_7f34, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7f39, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7f3c, 6); imul(eax, eax, 0x276);                  /* imul eax, eax, 0x276 */
            ii(0x1010_7f42, 6); mov(ebx, memd_a32[ds, 0x101c_4dac]);    /* mov ebx, [0x101c4dac] */
            ii(0x1010_7f48, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1010_7f4a, 6); mov(ax, memw_a32[ds, 0x101c_40d0]);     /* mov ax, [0x101c40d0] */
            ii(0x1010_7f50, 4); mov(memw_a32[ds, ebx + 0x4c], ax);      /* mov [ebx+0x4c], ax */
            ii(0x1010_7f54, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1010_7f57, 3); add(ebx, 0x26);                         /* add ebx, 0x26 */
            ii(0x1010_7f5a, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7f5f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7f62, 6); imul(eax, eax, 0x276);                  /* imul eax, eax, 0x276 */
            ii(0x1010_7f68, 6); mov(edx, memd_a32[ds, 0x101c_4dac]);    /* mov edx, [0x101c4dac] */
            ii(0x1010_7f6e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7f70, 4); mov(memw_a32[ds, eax + 0x28], bx);      /* mov [eax+0x28], bx */
            ii(0x1010_7f74, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1010_7f77, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1010_7f7a, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7f7f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7f82, 6); imul(eax, eax, 0x276);                  /* imul eax, eax, 0x276 */
            ii(0x1010_7f88, 6); mov(ecx, memd_a32[ds, 0x101c_4dac]);    /* mov ecx, [0x101c4dac] */
            ii(0x1010_7f8e, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1010_7f90, 3); add(eax, 0x50);                         /* add eax, 0x50 */
            ii(0x1010_7f93, 5); calld(Definitions.sys_memcpy, 0x5_deb3); /* call 0x10165e4b */
            ii(0x1010_7f98, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_7f9c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_7f9e, 2); if(jld(0x1010_7fc6, 0x26)) goto l_0x1010_7fc6; /* jl 0x10107fc6 */
            ii(0x1010_7fa0, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_7fa4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7fa6, 6); mov(dl, memb_a32[ds, eax + 0x101c_40b4]); /* mov dl, [eax+0x101c40b4] */
            ii(0x1010_7fac, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7fb1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7fb4, 6); imul(ebx, eax, 0x276);                  /* imul ebx, eax, 0x276 */
            ii(0x1010_7fba, 5); mov(eax, memd_a32[ds, 0x101c_4dac]);    /* mov eax, [0x101c4dac] */
            ii(0x1010_7fbf, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1010_7fc1, 3); mov(memd_a32[ds, eax + 0x48], edx);     /* mov [eax+0x48], edx */
            ii(0x1010_7fc4, 2); jmpd(0x1010_7fe2, 0x1c); goto l_0x1010_7fe2; /* jmp 0x10107fe2 */
        l_0x1010_7fc6:
            ii(0x1010_7fc6, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7fcb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7fce, 6); imul(edx, eax, 0x276);                  /* imul edx, eax, 0x276 */
            ii(0x1010_7fd4, 5); mov(eax, memd_a32[ds, 0x101c_4dac]);    /* mov eax, [0x101c4dac] */
            ii(0x1010_7fd9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7fdb, 7); mov(memd_a32[ds, eax + 0x48], 0);       /* mov dword [eax+0x48], 0x0 */
        l_0x1010_7fe2:
            ii(0x1010_7fe2, 5); mov(eax, memd_a32[ds, 0x101c_4db4]);    /* mov eax, [0x101c4db4] */
            ii(0x1010_7fe7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_7fea, 6); imul(eax, eax, 0x276);                  /* imul eax, eax, 0x276 */
            ii(0x1010_7ff0, 6); mov(edx, memd_a32[ds, 0x101c_4dac]);    /* mov edx, [0x101c4dac] */
            ii(0x1010_7ff6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7ff8, 5); calld(0x1010_77ad, -0x850);             /* call 0x101077ad */
            ii(0x1010_7ffd, 6); mov(edx, memd_a32[ds, 0x101c_4db4]);    /* mov edx, [0x101c4db4] */
            ii(0x1010_8003, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_8006, 1); inc(edx);                               /* inc edx */
            ii(0x1010_8007, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1010_800c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_800e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_8011, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_8013, 7); mov(memw_a32[ds, 0x101c_4db6], dx);     /* mov [0x101c4db6], dx */
            ii(0x1010_801a, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_801e, 2); if(jnzd(0x1010_8029, 0x9)) goto l_0x1010_8029; /* jnz 0x10108029 */
            ii(0x1010_8020, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_8024, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1010_8027, 2); if(jnzd(0x1010_802e, 0x5)) goto l_0x1010_802e; /* jnz 0x1010802e */
        l_0x1010_8029:
            ii(0x1010_8029, 5); jmpd(0x1010_812c, 0xfe); goto l_0x1010_812c; /* jmp 0x1010812c */
        l_0x1010_802e:
            ii(0x1010_802e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_8031, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_8034, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_8038, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_803b, 6); mov(eax, memd_a32[ds, eax + 0x101c_4150]); /* mov eax, [eax+0x101c4150] */
            ii(0x1010_8041, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_8044, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_8048, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_804b, 6); mov(eax, memd_a32[ds, eax + 0x101c_4770]); /* mov eax, [eax+0x101c4770] */
            ii(0x1010_8051, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1010_8054, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_8058, 6); mov(al, memb_a32[ds, eax + 0x101c_40b4]); /* mov al, [eax+0x101c40b4] */
            ii(0x1010_805e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_8063, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1010_8065, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_8069, 3); shl(edx, 0x7);                          /* shl edx, 0x7 */
            ii(0x1010_806c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_806e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_8071, 7); mov(memw_a32[ds, edx + 0x101c_4780], ax); /* mov [edx+0x101c4780], ax */
            ii(0x1010_8078, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_807c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_807f, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_8083, 6); mov(dl, memb_a32[ds, edx + 0x101c_40b4]); /* mov dl, [edx+0x101c40b4] */
            ii(0x1010_8089, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1010_808f, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_8092, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1010_8094, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_8098, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1010_809b, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1010_809d, 6); mov(eax, memd_a32[ds, eax + 0x101c_4770]); /* mov eax, [eax+0x101c4770] */
            ii(0x1010_80a3, 6); mov(memd_a32[ds, edx + 0x101c_4980], eax); /* mov [edx+0x101c4980], eax */
            ii(0x1010_80a9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_80ac, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_80af, 5); cmp(eax, 0x400);                        /* cmp eax, 0x400 */
            ii(0x1010_80b4, 2); if(jbed(0x1010_80e5, 0x2f)) goto l_0x1010_80e5; /* jbe 0x101080e5 */
            ii(0x1010_80b6, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1010_80bb, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1010_80be, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1010_80c1, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x1010_80c4, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1010_80c7, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_80ca, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x1010_80cd, 5); calld(Definitions.sys_memcpy, 0x5_dd79); /* call 0x10165e4b */
            ii(0x1010_80d2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_80d5, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
            ii(0x1010_80d8, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1010_80df, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1010_80e2, 3); sub(memd_a32[ss, ebp - 0xc], eax);      /* sub [ebp-0xc], eax */
        l_0x1010_80e5:
            ii(0x1010_80e5, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1010_80e8, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1010_80eb, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1010_80ee, 3); add(eax, memd_a32[ss, ebp - 0x20]);     /* add eax, [ebp-0x20] */
            ii(0x1010_80f1, 5); calld(Definitions.sys_memcpy, 0x5_dd55); /* call 0x10165e4b */
            ii(0x1010_80f6, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_80f9, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1010_80fc, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1010_8100, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_8103, 6); mov(memd_a32[ds, edx + 0x101c_4770], eax); /* mov [edx+0x101c4770], eax */
            ii(0x1010_8109, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_810d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_810f, 6); mov(dl, memb_a32[ds, eax + 0x101c_40b4]); /* mov dl, [eax+0x101c40b4] */
            ii(0x1010_8115, 1); inc(edx);                               /* inc edx */
            ii(0x1010_8116, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x1010_811b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_811d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_8120, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_8122, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1010_8126, 6); mov(memb_a32[ds, eax + 0x101c_40b4], dl); /* mov [eax+0x101c40b4], dl */
        l_0x1010_812c:
            ii(0x1010_812c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_812e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_812f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_8130, 1); popd(esi);                              /* pop esi */
            ii(0x1010_8131, 1); retd(); return;                         /* ret */
        }
    }
}
