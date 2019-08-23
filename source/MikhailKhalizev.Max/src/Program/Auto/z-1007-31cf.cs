using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_31cf-45e07e81")]
        public void Method_1007_31cf()
        {
            ii(0x1007_31cf, 5); push(0x40);                             /* push 0x40 */
            ii(0x1007_31d4, 5); call(Definitions.sys_check_available_stack_size, 0xf_2b79); /* call 0x10165d52 */
            ii(0x1007_31d9, 1); push(ebx);                              /* push ebx */
            ii(0x1007_31da, 1); push(ecx);                              /* push ecx */
            ii(0x1007_31db, 1); push(esi);                              /* push esi */
            ii(0x1007_31dc, 1); push(edi);                              /* push edi */
            ii(0x1007_31dd, 1); push(ebp);                              /* push ebp */
            ii(0x1007_31de, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_31e0, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1007_31e6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_31e9, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1007_31ec, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_31f3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_31f6, 5); call(0x1007_61d4, 0x2fd9);              /* call 0x100761d4 */
            ii(0x1007_31fb, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_31fe, 4); or(memb[ss, ebp - 0x14], 0x1);          /* or byte [ebp-0x14], 0x1 */
            ii(0x1007_3202, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_3205, 5); call(0x1007_64fc, 0x32f2);              /* call 0x100764fc */
            ii(0x1007_320a, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_320d, 4); and(memb[ss, ebp - 0x14], -0x2 /* 0xfe */); /* and byte [ebp-0x14], 0xfe */
            ii(0x1007_3211, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3214, 3); mov(ebx, memd[ds, eax + 0x41]);         /* mov ebx, [eax+0x41] */
            ii(0x1007_3217, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_321a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_321d, 3); mov(edx, memd[ds, eax + 0x3f]);         /* mov edx, [eax+0x3f] */
            ii(0x1007_3220, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_3223, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1007_3226, 5); call(0x1007_6aac, 0x3881);              /* call 0x10076aac */
            ii(0x1007_322b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_322e, 5); call(0x1007_307a, -0x1b9);              /* call 0x1007307a */
            ii(0x1007_3233, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_3235, 2); if(jnz(0x1007_3246, 0xf)) goto l_0x1007_3246; /* jnz 0x10073246 */
            ii(0x1007_3237, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3239, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_323c, 5); call(0x1007_5f6c, 0x2d2b);              /* call 0x10075f6c */
            ii(0x1007_3241, 5); jmp(0x1007_34cf, 0x289); goto l_0x1007_34cf; /* jmp 0x100734cf */
        l_0x1007_3246:
            ii(0x1007_3246, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3249, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_324d, 2); if(jnz(0x1007_3282, 0x33)) goto l_0x1007_3282; /* jnz 0x10073282 */
            ii(0x1007_324f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3252, 5); call(0x1007_60e4, 0x2e8d);              /* call 0x100760e4 */
            ii(0x1007_3257, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_325a, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1007_325e, 2); if(jz(0x1007_3269, 0x9)) goto l_0x1007_3269; /* jz 0x10073269 */
            ii(0x1007_3260, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_3267, 2); jmp(0x1007_3282, 0x19); goto l_0x1007_3282; /* jmp 0x10073282 */
        l_0x1007_3269:
            ii(0x1007_3269, 5); mov(ecx, 0x5c2);                        /* mov ecx, 0x5c2 */
            ii(0x1007_326e, 5); mov(ebx, StringDefinitions.AccessCpp);  /* mov ebx, 0x101a0054 */
            ii(0x1007_3273, 5); mov(edx, StringDefinitions.EnemyNotEqual0); /* mov edx, 0x101a005f */
            ii(0x1007_3278, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_327a, 5); call(Definitions.sys_assert, 0xf_2b13); /* call 0x10165d92 */
            ii(0x1007_327f, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
        l_0x1007_3282:
            ii(0x1007_3282, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_3285, 5); call(0x1007_6338, 0x30ae);              /* call 0x10076338 */
            ii(0x1007_328a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_328c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_328f, 5); call(0x1007_643c, 0x31a8);              /* call 0x1007643c */
            ii(0x1007_3294, 2); jmp(0x1007_329e, 0x8); goto l_0x1007_329e; /* jmp 0x1007329e */
        l_0x1007_3296:
            ii(0x1007_3296, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_3299, 5); call(0x1007_6bf8, 0x395a);              /* call 0x10076bf8 */
        l_0x1007_329e:
            ii(0x1007_329e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_32a0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_32a3, 5); call(0x1013_ad71, 0xc_7ac9);            /* call 0x1013ad71 */
            ii(0x1007_32a8, 2); test(al, al);                           /* test al, al */
            ii(0x1007_32aa, 6); if(jz(0x1007_34c5, 0x215)) goto l_0x1007_34c5; /* jz 0x100734c5 */
            ii(0x1007_32b0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_32b3, 5); call(0x1007_6408, 0x3150);              /* call 0x10076408 */
            ii(0x1007_32b8, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_32bb, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_32bf, 2); if(jnz(0x1007_32d1, 0x10)) goto l_0x1007_32d1; /* jnz 0x100732d1 */
            ii(0x1007_32c1, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_32c4, 3); mov(al, memb[ds, eax + 0x4f]);          /* mov al, [eax+0x4f] */
            ii(0x1007_32c7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_32cc, 1); dec(eax);                               /* dec eax */
            ii(0x1007_32cd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_32cf, 2); if(jz(0x1007_32ff, 0x2e)) goto l_0x1007_32ff; /* jz 0x100732ff */
        l_0x1007_32d1:
            ii(0x1007_32d1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_32d4, 5); call(0x1007_63a0, 0x30c7);              /* call 0x100763a0 */
            ii(0x1007_32d9, 4); cmp(memb[ds, eax + 0x3d], 0x2);         /* cmp byte [eax+0x3d], 0x2 */
            ii(0x1007_32dd, 2); if(jz(0x1007_32ed, 0xe)) goto l_0x1007_32ed; /* jz 0x100732ed */
            ii(0x1007_32df, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_32e2, 5); call(0x1007_63a0, 0x30b9);              /* call 0x100763a0 */
            ii(0x1007_32e7, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_32eb, 2); if(jnz(0x1007_32ef, 0x2)) goto l_0x1007_32ef; /* jnz 0x100732ef */
        l_0x1007_32ed:
            ii(0x1007_32ed, 2); jmp(0x1007_32fd, 0xe); goto l_0x1007_32fd; /* jmp 0x100732fd */
        l_0x1007_32ef:
            ii(0x1007_32ef, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_32f2, 5); call(0x1007_63a0, 0x30a9);              /* call 0x100763a0 */
            ii(0x1007_32f7, 4); cmp(memb[ds, eax + 0x3d], 0);           /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1007_32fb, 2); if(jnz(0x1007_32ff, 0x2)) goto l_0x1007_32ff; /* jnz 0x100732ff */
        l_0x1007_32fd:
            ii(0x1007_32fd, 2); jmp(0x1007_3304, 0x5); goto l_0x1007_3304; /* jmp 0x10073304 */
        l_0x1007_32ff:
            ii(0x1007_32ff, 5); jmp(0x1007_34c0, 0x1bc); goto l_0x1007_34c0; /* jmp 0x100734c0 */
        l_0x1007_3304:
            ii(0x1007_3304, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3307, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_330b, 2); if(jnz(0x1007_337f, 0x72)) goto l_0x1007_337f; /* jnz 0x1007337f */
            ii(0x1007_330d, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3310, 5); call(0x1007_623c, 0x2f27);              /* call 0x1007623c */
            ii(0x1007_3315, 5); cmp(memw[ds, eax + 0xe], 0);            /* cmp word [eax+0xe], 0x0 */
            ii(0x1007_331a, 2); if(jz(0x1007_332b, 0xf)) goto l_0x1007_332b; /* jz 0x1007332b */
            ii(0x1007_331c, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_331f, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3322, 5); call(0x1007_4bde, 0x18b7);              /* call 0x10074bde */
            ii(0x1007_3327, 2); test(al, al);                           /* test al, al */
            ii(0x1007_3329, 2); if(jnz(0x1007_332d, 0x2)) goto l_0x1007_332d; /* jnz 0x1007332d */
        l_0x1007_332b:
            ii(0x1007_332b, 2); jmp(0x1007_337a, 0x4d); goto l_0x1007_337a; /* jmp 0x1007337a */
        l_0x1007_332d:
            ii(0x1007_332d, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3330, 4); mov(memb[ds, eax + 0x4f], 0);           /* mov byte [eax+0x4f], 0x0 */
            ii(0x1007_3334, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3337, 4); mov(dx, memw[ds, eax + 0x41]);          /* mov dx, [eax+0x41] */
            ii(0x1007_333b, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_333e, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x1007_3342, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3345, 4); mov(dx, memw[ds, eax + 0x43]);          /* mov dx, [eax+0x43] */
            ii(0x1007_3349, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_334c, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
            ii(0x1007_3350, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_3353, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3356, 5); call(0x1007_60ac, 0x2d51);              /* call 0x100760ac */
            ii(0x1007_335b, 5); mov(ebx, 0x2a);                         /* mov ebx, 0x2a */
            ii(0x1007_3360, 5); mov(edx, 0x1e);                         /* mov edx, 0x1e */
            ii(0x1007_3365, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3368, 5); call(0x1016_3053, 0xe_fce6);            /* call 0x10163053 */
            ii(0x1007_336d, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1007_3372, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3375, 5); call(0x1011_b7de, 0xa_8464);            /* call 0x1011b7de */
        l_0x1007_337a:
            ii(0x1007_337a, 5); jmp(0x1007_34c0, 0x141); goto l_0x1007_34c0; /* jmp 0x100734c0 */
        l_0x1007_337f:
            ii(0x1007_337f, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3382, 4); mov(ax, memw[ds, eax + 0x1e]);          /* mov ax, [eax+0x1e] */
            ii(0x1007_3386, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_3389, 4); sub(ax, memw[ds, edx + 0x1e]);          /* sub ax, [edx+0x1e] */
            ii(0x1007_338d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_338f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3392, 4); mov(dx, memw[ds, eax + 0x41]);          /* mov dx, [eax+0x41] */
            ii(0x1007_3396, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3399, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1007_339b, 4); mov(memw[ds, eax + 0x41], bx);          /* mov [eax+0x41], bx */
            ii(0x1007_339f, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_33a2, 4); mov(ax, memw[ds, eax + 0x20]);          /* mov ax, [eax+0x20] */
            ii(0x1007_33a6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_33a9, 4); sub(ax, memw[ds, edx + 0x20]);          /* sub ax, [edx+0x20] */
            ii(0x1007_33ad, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_33af, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_33b2, 4); mov(dx, memw[ds, eax + 0x43]);          /* mov dx, [eax+0x43] */
            ii(0x1007_33b6, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_33b9, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1007_33bb, 4); mov(memw[ds, eax + 0x43], bx);          /* mov [eax+0x43], bx */
            ii(0x1007_33bf, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_33c2, 3); mov(eax, memd[ds, eax + 0x3f]);         /* mov eax, [eax+0x3f] */
            ii(0x1007_33c5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_33c8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_33ca, 2); if(jge(0x1007_33d7, 0xb)) goto l_0x1007_33d7; /* jge 0x100733d7 */
            ii(0x1007_33cc, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_33cf, 6); mov(memw[ds, eax + 0x41], 0);           /* mov word [eax+0x41], 0x0 */
            ii(0x1007_33d5, 2); jmp(0x1007_33f5, 0x1e); goto l_0x1007_33f5; /* jmp 0x100733f5 */
        l_0x1007_33d7:
            ii(0x1007_33d7, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_33da, 4); mov(ax, memw[ds, eax + 0x41]);          /* mov ax, [eax+0x41] */
            ii(0x1007_33de, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1007_33e5, 2); if(jl(0x1007_33f5, 0xe)) goto l_0x1007_33f5; /* jl 0x100733f5 */
            ii(0x1007_33e7, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x1007_33ed, 1); dec(eax);                               /* dec eax */
            ii(0x1007_33ee, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x1007_33f1, 4); mov(memw[ds, edx + 0x41], ax);          /* mov [edx+0x41], ax */
        l_0x1007_33f5:
            ii(0x1007_33f5, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_33f8, 3); mov(eax, memd[ds, eax + 0x41]);         /* mov eax, [eax+0x41] */
            ii(0x1007_33fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_33fe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_3400, 2); if(jge(0x1007_340d, 0xb)) goto l_0x1007_340d; /* jge 0x1007340d */
            ii(0x1007_3402, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3405, 6); mov(memw[ds, eax + 0x43], 0);           /* mov word [eax+0x43], 0x0 */
            ii(0x1007_340b, 2); jmp(0x1007_342b, 0x1e); goto l_0x1007_342b; /* jmp 0x1007342b */
        l_0x1007_340d:
            ii(0x1007_340d, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3410, 4); mov(ax, memw[ds, eax + 0x43]);          /* mov ax, [eax+0x43] */
            ii(0x1007_3414, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1007_341b, 2); if(jl(0x1007_342b, 0xe)) goto l_0x1007_342b; /* jl 0x1007342b */
            ii(0x1007_341d, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x1007_3423, 1); dec(eax);                               /* dec eax */
            ii(0x1007_3424, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x1007_3427, 4); mov(memw[ds, edx + 0x43], ax);          /* mov [edx+0x43], ax */
        l_0x1007_342b:
            ii(0x1007_342b, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_342e, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1007_3432, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3435, 4); cmp(dx, memw[ds, eax + 0x41]);          /* cmp dx, [eax+0x41] */
            ii(0x1007_3439, 2); if(jnz(0x1007_344f, 0x14)) goto l_0x1007_344f; /* jnz 0x1007344f */
            ii(0x1007_343b, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_343e, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1007_3442, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3445, 4); cmp(dx, memw[ds, eax + 0x43]);          /* cmp dx, [eax+0x43] */
            ii(0x1007_3449, 6); if(jz(0x1007_34c0, 0x71)) goto l_0x1007_34c0; /* jz 0x100734c0 */
        l_0x1007_344f:
            ii(0x1007_344f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_3451, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3454, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1007_3457, 5); call(0x1007_6a34, 0x35d8);              /* call 0x10076a34 */
            ii(0x1007_345c, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_345f, 4); cmp(memb[ds, eax + 0x3d], 0x1e);        /* cmp byte [eax+0x3d], 0x1e */
            ii(0x1007_3463, 2); if(jnz(0x1007_3473, 0xe)) goto l_0x1007_3473; /* jnz 0x10073473 */
            ii(0x1007_3465, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3468, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1007_346c, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_346f, 4); mov(memb[ds, eax + 0x3e], 0x1);         /* mov byte [eax+0x3e], 0x1 */
        l_0x1007_3473:
            ii(0x1007_3473, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3476, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1007_347a, 2); if(jz(0x1007_349d, 0x21)) goto l_0x1007_349d; /* jz 0x1007349d */
            ii(0x1007_347c, 5); mov(ebx, 0x2a);                         /* mov ebx, 0x2a */
            ii(0x1007_3481, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1007_3486, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_3489, 5); call(0x1016_3053, 0xe_fbc5);            /* call 0x10163053 */
            ii(0x1007_348e, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x1007_3491, 5); mov(eax, 0x101c_9478);                  /* mov eax, 0x101c9478 */
            ii(0x1007_3496, 5); call(0x1007_6630, 0x3195);              /* call 0x10076630 */
            ii(0x1007_349b, 2); jmp(0x1007_34c0, 0x23); goto l_0x1007_34c0; /* jmp 0x100734c0 */
        l_0x1007_349d:
            ii(0x1007_349d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1007_34a2, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_34a5, 5); call(0x1011_b7de, 0xa_8334);            /* call 0x1011b7de */
            ii(0x1007_34aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_34ac, 2); if(jz(0x1007_34c0, 0x12)) goto l_0x1007_34c0; /* jz 0x100734c0 */
            ii(0x1007_34ae, 5); mov(ebx, 0x2a);                         /* mov ebx, 0x2a */
            ii(0x1007_34b3, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1007_34b8, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_34bb, 5); call(0x1016_3053, 0xe_fb93);            /* call 0x10163053 */
        l_0x1007_34c0:
            ii(0x1007_34c0, 5); jmp(0x1007_3296, -0x22f); goto l_0x1007_3296; /* jmp 0x10073296 */
        l_0x1007_34c5:
            ii(0x1007_34c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_34c7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_34ca, 5); call(0x1007_5f6c, 0x2a9d);              /* call 0x10075f6c */
        l_0x1007_34cf:
            ii(0x1007_34cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_34d1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_34d2, 1); pop(edi);                               /* pop edi */
            ii(0x1007_34d3, 1); pop(esi);                               /* pop esi */
            ii(0x1007_34d4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_34d5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_34d6, 1); ret();                                  /* ret */
        }
    }
}
