using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_41a4-d98735f2")]
        public void /* sys */ Method_1018_41a4()
        {
            ii(0x1018_41a4, 1); push(esi);                              /* push esi */
            ii(0x1018_41a5, 1); push(edi);                              /* push edi */
            ii(0x1018_41a6, 1); push(ebp);                              /* push ebp */
            ii(0x1018_41a7, 3); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1018_41aa, 4); mov(memd[ss, esp + 0x34], eax);         /* mov [esp+0x34], eax */
            ii(0x1018_41ae, 4); mov(memd[ss, esp + 0x38], edx);         /* mov [esp+0x38], edx */
            ii(0x1018_41b2, 4); mov(memd[ss, esp + 0x2c], ebx);         /* mov [esp+0x2c], ebx */
            ii(0x1018_41b6, 4); mov(memd[ss, esp + 0x24], ecx);         /* mov [esp+0x24], ecx */
            ii(0x1018_41ba, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1018_41bf, 4); mov(ebx, memd[ss, esp + 0x5c]);         /* mov ebx, [esp+0x5c] */
            ii(0x1018_41c3, 4); mov(memd[ss, esp + 0x20], edx);         /* mov [esp+0x20], edx */
            ii(0x1018_41c7, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1018_41c9, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_41cb, 6); if(jz(0x1018_42e8, 0x117)) goto l_0x1018_42e8; /* jz 0x101842e8 */
            ii(0x1018_41d1, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1018_41d3, 5); call(/* sys */ 0x1016_7dac, -0x1_c42c); /* call 0x10167dac */
            ii(0x1018_41d8, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x1018_41db, 4); mov(edx, memd[ss, esp + 0x60]);         /* mov edx, [esp+0x60] */
            ii(0x1018_41df, 4); mov(memd[ss, esp + 0x18], eax);         /* mov [esp+0x18], eax */
            ii(0x1018_41e3, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1018_41ea, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_41ec, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_41ef, 3); lea(edx, ebx + eax);                    /* lea edx, [ebx+eax] */
            ii(0x1018_41f2, 3); mov(eax, memd[ds, edx + 0x18]);         /* mov eax, [edx+0x18] */
            ii(0x1018_41f5, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1018_41f9, 3); mov(eax, memd[ds, edx + 0x1c]);         /* mov eax, [edx+0x1c] */
            ii(0x1018_41fc, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
            ii(0x1018_4200, 3); mov(ebx, memd[ds, edx + 0x24]);         /* mov ebx, [edx+0x24] */
            ii(0x1018_4203, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1018_4205, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_4209, 4); mov(ecx, memd[ss, esp + 0x8]);          /* mov ecx, [esp+0x8] */
            ii(0x1018_420d, 3); mov(edi, memd[ds, edx + 0x20]);         /* mov edi, [edx+0x20] */
            ii(0x1018_4210, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_4212, 2); sub(edi, ecx);                          /* sub edi, ecx */
            ii(0x1018_4214, 5); call(/* sys */ 0x1016_7e3c, -0x1_c3dd); /* call 0x10167e3c */
            ii(0x1018_4219, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_421b, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_421f, 1); inc(edi);                               /* inc edi */
            ii(0x1018_4220, 6); mov(dl, memb[ds, eax + 0x235]);         /* mov dl, [eax+0x235] */
            ii(0x1018_4226, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_4227, 3); test(dl, 0xff);                         /* test dl, 0xff */
            ii(0x1018_422a, 2); if(jz(0x1018_4257, 0x2b)) goto l_0x1018_4257; /* jz 0x10184257 */
            ii(0x1018_422c, 6); mov(eax, memd[ds, eax + 0x234]);        /* mov eax, [eax+0x234] */
            ii(0x1018_4232, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_4237, 7); mov(eax, memd[ds, eax * 4 + 0x101b_d9bc]); /* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1018_423e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_4240, 6); mov(dl, memb[ds, eax + 0x1020_0520]);   /* mov dl, [eax+0x10200520] */
            ii(0x1018_4246, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_424a, 6); mov(eax, memd[ds, eax + 0x234]);        /* mov eax, [eax+0x234] */
            ii(0x1018_4250, 3); xor(ax, ax);                            /* xor ax, ax */
            ii(0x1018_4253, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1018_4255, 2); jmp(0x1018_425d, 0x6); goto l_0x1018_425d; /* jmp 0x1018425d */
        l_0x1018_4257:
            ii(0x1018_4257, 6); mov(eax, memd[ds, eax + 0x234]);        /* mov eax, [eax+0x234] */
        l_0x1018_425d:
            ii(0x1018_425d, 4); mov(memd[ss, esp + 0x10], eax);         /* mov [esp+0x10], eax */
            ii(0x1018_4261, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_4265, 7); test(memb[ds, eax + 0x239], 0xff);      /* test byte [eax+0x239], 0xff */
            ii(0x1018_426c, 2); if(jz(0x1018_429c, 0x2e)) goto l_0x1018_429c; /* jz 0x1018429c */
            ii(0x1018_426e, 6); mov(eax, memd[ds, eax + 0x238]);        /* mov eax, [eax+0x238] */
            ii(0x1018_4274, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_4279, 7); mov(eax, memd[ds, eax * 4 + 0x101b_d9bc]); /* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1018_4280, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1018_4286, 4); mov(edx, memd[ss, esp + 0x5c]);         /* mov edx, [esp+0x5c] */
            ii(0x1018_428a, 6); mov(edx, memd[ds, edx + 0x238]);        /* mov edx, [edx+0x238] */
            ii(0x1018_4290, 3); xor(dx, dx);                            /* xor dx, dx */
            ii(0x1018_4293, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_4298, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1018_429a, 2); jmp(0x1018_42a2, 0x6); goto l_0x1018_42a2; /* jmp 0x101842a2 */
        l_0x1018_429c:
            ii(0x1018_429c, 6); mov(eax, memd[ds, eax + 0x238]);        /* mov eax, [eax+0x238] */
        l_0x1018_42a2:
            ii(0x1018_42a2, 4); mov(edx, memd[ss, esp + 0x18]);         /* mov edx, [esp+0x18] */
            ii(0x1018_42a6, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1018_42aa, 1); push(eax);                              /* push eax */
            ii(0x1018_42ab, 4); add(edx, memd[ss, esp + 0xc]);          /* add edx, [esp+0xc] */
            ii(0x1018_42af, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1018_42b3, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1018_42b6, 4); mov(ebp, memd[ss, esp + 0x14]);         /* mov ebp, [esp+0x14] */
            ii(0x1018_42ba, 1); push(ebp);                              /* push ebp */
            ii(0x1018_42bb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_42bd, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_42bf, 5); call(/* sys */ 0x1016_af8c, -0x1_9338); /* call 0x1016af8c */
            ii(0x1018_42c4, 4); mov(edx, memd[ss, esp + 0x60]);         /* mov edx, [esp+0x60] */
            ii(0x1018_42c8, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1018_42cf, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_42d1, 4); mov(edx, memd[ss, esp + 0x5c]);         /* mov edx, [esp+0x5c] */
            ii(0x1018_42d5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_42d8, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x1018_42db, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_42dd, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_42e1, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_42e3, 5); call(Definitions.sys_display_draw_1, -0x1_ce40); /* call 0x101674a8 */
        l_0x1018_42e8:
            ii(0x1018_42e8, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1018_42ec, 4); mov(edx, memd[ss, esp + 0x38]);         /* mov edx, [esp+0x38] */
            ii(0x1018_42f0, 5); call(/* sys */ 0x1016_7dac, -0x1_c549); /* call 0x10167dac */
            ii(0x1018_42f5, 3); mov(ebx, memd[ds, eax + 0x2c]);         /* mov ebx, [eax+0x2c] */
            ii(0x1018_42f8, 4); mov(eax, memd[ss, esp + 0x38]);         /* mov eax, [esp+0x38] */
            ii(0x1018_42fc, 2); mov(ecx, memd[ds, edx]);                /* mov ecx, [edx] */
            ii(0x1018_42fe, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1018_4301, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1018_4303, 1); inc(eax);                               /* inc eax */
            ii(0x1018_4304, 3); mov(edi, memd[ds, edx + 0x4]);          /* mov edi, [edx+0x4] */
            ii(0x1018_4307, 4); mov(memd[ss, esp + 0x28], eax);         /* mov [esp+0x28], eax */
            ii(0x1018_430b, 3); mov(eax, memd[ds, edx + 0xc]);          /* mov eax, [edx+0xc] */
            ii(0x1018_430e, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1018_4310, 5); mov(ebp, 0xffff_fffc);                  /* mov ebp, 0xfffffffc */
            ii(0x1018_4315, 3); lea(ecx, eax + 0x1);                    /* lea ecx, [eax+0x1] */
            ii(0x1018_4318, 4); lea(edx, esp + 0x4);                    /* lea edx, [esp+0x4] */
            ii(0x1018_431c, 4); lea(eax, esp + 0x8);                    /* lea eax, [esp+0x8] */
            ii(0x1018_4320, 5); mov(edi, 0x4);                          /* mov edi, 0x4 */
            ii(0x1018_4325, 5); call(/* sys */ 0x1016_c298, -0x1_8092); /* call 0x1016c298 */
        l_0x1018_432a:
            ii(0x1018_432a, 5); call(/* sys */ 0x1016_b208, -0x1_9127); /* call 0x1016b208 */
            ii(0x1018_432f, 4); mov(memd[ss, esp + 0x3c], eax);         /* mov [esp+0x3c], eax */
            ii(0x1018_4333, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_4336, 2); if(jnz(0x1018_4375, 0x3d)) goto l_0x1018_4375; /* jnz 0x10184375 */
            ii(0x1018_4338, 4); lea(edx, esp + 0xc);                    /* lea edx, [esp+0xc] */
            ii(0x1018_433c, 4); lea(eax, esp + 0x10);                   /* lea eax, [esp+0x10] */
            ii(0x1018_4340, 5); call(/* sys */ 0x1016_c298, -0x1_80ad); /* call 0x1016c298 */
            ii(0x1018_4345, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1018_4349, 4); mov(edx, memd[ss, esp + 0x10]);         /* mov edx, [esp+0x10] */
            ii(0x1018_434d, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1018_434f, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_4351, 2); if(jg(0x1018_4375, 0x22)) goto l_0x1018_4375; /* jg 0x10184375 */
            ii(0x1018_4353, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1018_4357, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1018_4359, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_435b, 2); if(jl(0x1018_4375, 0x18)) goto l_0x1018_4375; /* jl 0x10184375 */
            ii(0x1018_435d, 4); mov(eax, memd[ss, esp + 0x4]);          /* mov eax, [esp+0x4] */
            ii(0x1018_4361, 4); mov(edx, memd[ss, esp + 0xc]);          /* mov edx, [esp+0xc] */
            ii(0x1018_4365, 2); add(eax, ebp);                          /* add eax, ebp */
            ii(0x1018_4367, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_4369, 2); if(jg(0x1018_4375, 0xa)) goto l_0x1018_4375; /* jg 0x10184375 */
            ii(0x1018_436b, 4); mov(eax, memd[ss, esp + 0x4]);          /* mov eax, [esp+0x4] */
            ii(0x1018_436f, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1018_4371, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_4373, 2); if(jge(0x1018_432a, -0x4b)) goto l_0x1018_432a; /* jge 0x1018432a */
        l_0x1018_4375:
            ii(0x1018_4375, 4); mov(eax, memd[ss, esp + 0x28]);         /* mov eax, [esp+0x28] */
            ii(0x1018_4379, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1018_437c, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1018_437f, 3); sub(ecx, 0x10);                         /* sub ecx, 0x10 */
            ii(0x1018_4382, 4); mov(memd[ss, esp + 0x30], eax);         /* mov [esp+0x30], eax */
            ii(0x1018_4386, 4); mov(eax, memd[ss, esp + 0x24]);         /* mov eax, [esp+0x24] */
            ii(0x1018_438a, 3); mov(memd[ss, esp], ebx);                /* mov [esp], ebx */
            ii(0x1018_438d, 1); dec(eax);                               /* dec eax */
            ii(0x1018_438e, 4); mov(memd[ss, esp + 0x1c], ecx);         /* mov [esp+0x1c], ecx */
            ii(0x1018_4392, 4); mov(memd[ss, esp + 0x40], eax);         /* mov [esp+0x40], eax */
        l_0x1018_4396:
            ii(0x1018_4396, 4); lea(edx, esp + 0xc);                    /* lea edx, [esp+0xc] */
            ii(0x1018_439a, 4); lea(eax, esp + 0x10);                   /* lea eax, [esp+0x10] */
            ii(0x1018_439e, 4); mov(ebx, memd[ss, esp + 0x3c]);         /* mov ebx, [esp+0x3c] */
            ii(0x1018_43a2, 5); call(/* sys */ 0x1016_c298, -0x1_810f); /* call 0x1016c298 */
            ii(0x1018_43a7, 3); cmp(ebx, -0x2 /* 0xfe */);              /* cmp ebx, 0xfffffffe */
            ii(0x1018_43aa, 6); if(jnz(0x1018_442b, 0x7b)) goto l_0x1018_442b; /* jnz 0x1018442b */
            ii(0x1018_43b0, 4); mov(ecx, memd[ss, esp + 0x5c]);         /* mov ecx, [esp+0x5c] */
            ii(0x1018_43b4, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_43b6, 6); if(jz(0x1018_442b, 0x6f)) goto l_0x1018_442b; /* jz 0x1018442b */
            ii(0x1018_43bc, 4); mov(ebx, memd[ss, esp + 0x5c]);         /* mov ebx, [esp+0x5c] */
            ii(0x1018_43c0, 4); mov(edx, memd[ss, esp + 0x5c]);         /* mov edx, [esp+0x5c] */
            ii(0x1018_43c4, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_43c8, 3); mov(ecx, memd[ds, ecx + 0x10]);         /* mov ecx, [ecx+0x10] */
            ii(0x1018_43cb, 3); mov(ebx, memd[ds, ebx + 0xc]);          /* mov ebx, [ebx+0xc] */
            ii(0x1018_43ce, 3); mov(edx, memd[ds, edx + 0x8]);          /* mov edx, [edx+0x8] */
            ii(0x1018_43d1, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1018_43d4, 5); call(/* sys */ 0x1016_c1f0, -0x1_81e9); /* call 0x1016c1f0 */
            ii(0x1018_43d9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_43db, 2); if(jz(0x1018_442b, 0x4e)) goto l_0x1018_442b; /* jz 0x1018442b */
            ii(0x1018_43dd, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_43e1, 3); mov(edi, memd[ds, eax + 0x14]);         /* mov edi, [eax+0x14] */
            ii(0x1018_43e4, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1018_43e6, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_43e8, 2); if(jle(0x1018_4410, 0x26)) goto l_0x1018_4410; /* jle 0x10184410 */
            ii(0x1018_43ea, 2); mov(edi, eax);                          /* mov edi, eax */
        l_0x1018_43ec:
            ii(0x1018_43ec, 3); mov(ecx, memd[ds, edi + 0x24]);         /* mov ecx, [edi+0x24] */
            ii(0x1018_43ef, 3); mov(ebx, memd[ds, edi + 0x20]);         /* mov ebx, [edi+0x20] */
            ii(0x1018_43f2, 3); mov(edx, memd[ds, edi + 0x1c]);         /* mov edx, [edi+0x1c] */
            ii(0x1018_43f5, 3); mov(eax, memd[ds, edi + 0x18]);         /* mov eax, [edi+0x18] */
            ii(0x1018_43f8, 5); call(/* sys */ 0x1016_c1f0, -0x1_820d); /* call 0x1016c1f0 */
            ii(0x1018_43fd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_43ff, 2); if(jnz(0x1018_4410, 0xf)) goto l_0x1018_4410; /* jnz 0x10184410 */
            ii(0x1018_4401, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_4405, 1); inc(ebp);                               /* inc ebp */
            ii(0x1018_4406, 3); mov(edx, memd[ds, eax + 0x14]);         /* mov edx, [eax+0x14] */
            ii(0x1018_4409, 3); add(edi, 0x24);                         /* add edi, 0x24 */
            ii(0x1018_440c, 2); cmp(ebp, edx);                          /* cmp ebp, edx */
            ii(0x1018_440e, 2); if(jl(0x1018_43ec, -0x24)) goto l_0x1018_43ec; /* jl 0x101843ec */
        l_0x1018_4410:
            ii(0x1018_4410, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_4414, 3); cmp(ebp, memd[ds, eax + 0x14]);         /* cmp ebp, [eax+0x14] */
            ii(0x1018_4417, 2); if(jge(0x1018_442b, 0x12)) goto l_0x1018_442b; /* jge 0x1018442b */
            ii(0x1018_4419, 4); cmp(ebp, memd[ss, esp + 0x60]);         /* cmp ebp, [esp+0x60] */
            ii(0x1018_441d, 2); if(jz(0x1018_442b, 0xc)) goto l_0x1018_442b; /* jz 0x1018442b */
            ii(0x1018_441f, 5); mov(esi, 0xffff_fffe);                  /* mov esi, 0xfffffffe */
            ii(0x1018_4424, 2); sub(esi, ebp);                          /* sub esi, ebp */
            ii(0x1018_4426, 5); jmp(0x1018_4674, 0x249); goto l_0x1018_4674; /* jmp 0x10184674 */
        l_0x1018_442b:
            ii(0x1018_442b, 5); call(/* sys */ 0x1016_c348, -0x1_80e8); /* call 0x1016c348 */
            ii(0x1018_4430, 2); test(al, 0x10);                         /* test al, 0x10 */
            ii(0x1018_4432, 2); if(jnz(0x1018_4446, 0x12)) goto l_0x1018_4446; /* jnz 0x10184446 */
            ii(0x1018_4434, 5); call(/* sys */ 0x1016_c348, -0x1_80f1); /* call 0x1016c348 */
            ii(0x1018_4439, 2); test(al, 0x1);                          /* test al, 0x1 */
            ii(0x1018_443b, 2); if(jz(0x1018_4475, 0x38)) goto l_0x1018_4475; /* jz 0x10184475 */
            ii(0x1018_443d, 5); call(/* sys */ 0x1016_c348, -0x1_80fa); /* call 0x1016c348 */
            ii(0x1018_4442, 2); test(al, 0x4);                          /* test al, 0x4 */
            ii(0x1018_4444, 2); if(jnz(0x1018_4475, 0x2f)) goto l_0x1018_4475; /* jnz 0x10184475 */
        l_0x1018_4446:
            ii(0x1018_4446, 4); mov(ecx, memd[ss, esp + 0x38]);         /* mov ecx, [esp+0x38] */
            ii(0x1018_444a, 4); mov(ebx, memd[ss, esp + 0x38]);         /* mov ebx, [esp+0x38] */
            ii(0x1018_444e, 4); mov(edx, memd[ss, esp + 0x38]);         /* mov edx, [esp+0x38] */
            ii(0x1018_4452, 4); mov(eax, memd[ss, esp + 0x38]);         /* mov eax, [esp+0x38] */
            ii(0x1018_4456, 3); mov(ecx, memd[ds, ecx + 0xc]);          /* mov ecx, [ecx+0xc] */
            ii(0x1018_4459, 3); mov(ebx, memd[ds, ebx + 0x8]);          /* mov ebx, [ebx+0x8] */
            ii(0x1018_445c, 3); mov(edx, memd[ds, edx + 0x4]);          /* mov edx, [edx+0x4] */
            ii(0x1018_445f, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_4461, 3); sub(ecx, 0x9);                          /* sub ecx, 0x9 */
            ii(0x1018_4464, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1018_4467, 5); call(/* sys */ 0x1016_c1f0, -0x1_827c); /* call 0x1016c1f0 */
            ii(0x1018_446c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_446e, 2); if(jz(0x1018_447e, 0xe)) goto l_0x1018_447e; /* jz 0x1018447e */
            ii(0x1018_4470, 5); jmp(0x1018_4674, 0x1ff); goto l_0x1018_4674; /* jmp 0x10184674 */
        l_0x1018_4475:
            ii(0x1018_4475, 4); mov(edi, memd[ss, esp + 0x3c]);         /* mov edi, [esp+0x3c] */
            ii(0x1018_4479, 3); cmp(edi, 0x1b);                         /* cmp edi, 0x1b */
            ii(0x1018_447c, 2); if(jnz(0x1018_4488, 0xa)) goto l_0x1018_4488; /* jnz 0x10184488 */
        l_0x1018_447e:
            ii(0x1018_447e, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
            ii(0x1018_4483, 5); jmp(0x1018_4674, 0x1ec); goto l_0x1018_4674; /* jmp 0x10184674 */
        l_0x1018_4488:
            ii(0x1018_4488, 3); cmp(edi, 0xd);                          /* cmp edi, 0xd */
            ii(0x1018_448b, 6); if(jz(0x1018_4674, 0x1e3)) goto l_0x1018_4674; /* jz 0x10184674 */
            ii(0x1018_4491, 6); cmp(edi, 0x14b);                        /* cmp edi, 0x14b */
            ii(0x1018_4497, 2); if(jnz(0x1018_44c1, 0x28)) goto l_0x1018_44c1; /* jnz 0x101844c1 */
            ii(0x1018_4499, 5); cmp(memd[ss, esp + 0x5c], 0);           /* cmp dword [esp+0x5c], 0x0 */
            ii(0x1018_449e, 6); if(jz(0x1018_45e7, 0x143)) goto l_0x1018_45e7; /* jz 0x101845e7 */
            ii(0x1018_44a4, 4); mov(ecx, memd[ss, esp + 0x60]);         /* mov ecx, [esp+0x60] */
            ii(0x1018_44a8, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_44aa, 6); if(jle(0x1018_45e7, 0x137)) goto l_0x1018_45e7; /* jle 0x101845e7 */
            ii(0x1018_44b0, 5); mov(eax, 0xffff_fffe);                  /* mov eax, 0xfffffffe */
            ii(0x1018_44b5, 3); lea(esi, ecx - 0x1);                    /* lea esi, [ecx-0x1] */
            ii(0x1018_44b8, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1018_44ba, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_44bc, 5); jmp(0x1018_4674, 0x1b3); goto l_0x1018_4674; /* jmp 0x10184674 */
        l_0x1018_44c1:
            ii(0x1018_44c1, 6); cmp(edi, 0x14d);                        /* cmp edi, 0x14d */
            ii(0x1018_44c7, 2); if(jnz(0x1018_44f6, 0x2d)) goto l_0x1018_44f6; /* jnz 0x101844f6 */
            ii(0x1018_44c9, 4); mov(ebp, memd[ss, esp + 0x5c]);         /* mov ebp, [esp+0x5c] */
            ii(0x1018_44cd, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1018_44cf, 6); if(jz(0x1018_45e7, 0x112)) goto l_0x1018_45e7; /* jz 0x101845e7 */
            ii(0x1018_44d5, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1018_44d8, 4); mov(edx, memd[ss, esp + 0x60]);         /* mov edx, [esp+0x60] */
            ii(0x1018_44dc, 1); dec(eax);                               /* dec eax */
            ii(0x1018_44dd, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_44df, 6); if(jle(0x1018_45e7, 0x102)) goto l_0x1018_45e7; /* jle 0x101845e7 */
            ii(0x1018_44e5, 5); mov(eax, 0xffff_fffe);                  /* mov eax, 0xfffffffe */
            ii(0x1018_44ea, 3); lea(esi, edx + 0x1);                    /* lea esi, [edx+0x1] */
            ii(0x1018_44ed, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1018_44ef, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_44f1, 5); jmp(0x1018_4674, 0x17e); goto l_0x1018_4674; /* jmp 0x10184674 */
        l_0x1018_44f6:
            ii(0x1018_44f6, 4); mov(ebx, memd[ss, esp + 0x2c]);         /* mov ebx, [esp+0x2c] */
            ii(0x1018_44fa, 7); lea(eax, esi * 4 + 0);                  /* lea eax, [esi*4] */
            ii(0x1018_4501, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1018_4503, 6); cmp(edi, 0x148);                        /* cmp edi, 0x148 */
            ii(0x1018_4509, 2); if(jnz(0x1018_452b, 0x20)) goto l_0x1018_452b; /* jnz 0x1018452b */
            ii(0x1018_450b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1018_450d:
            ii(0x1018_450d, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1018_450f, 2); if(jle(0x1018_451e, 0xd)) goto l_0x1018_451e; /* jle 0x1018451e */
            ii(0x1018_4511, 3); mov(edx, memd[ds, eax - 0x4]);          /* mov edx, [eax-0x4] */
            ii(0x1018_4514, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1018_4517, 2); mov(cl, memb[ds, edx]);                 /* mov cl, [edx] */
            ii(0x1018_4519, 1); dec(esi);                               /* dec esi */
            ii(0x1018_451a, 2); cmp(bl, cl);                            /* cmp bl, cl */
            ii(0x1018_451c, 2); if(jz(0x1018_450d, -0x11)) goto l_0x1018_450d; /* jz 0x1018450d */
        l_0x1018_451e:
            ii(0x1018_451e, 8); mov(memd[ss, esp + 0x3c], 0xffff_fffd); /* mov dword [esp+0x3c], 0xfffffffd */
            ii(0x1018_4526, 5); jmp(0x1018_45e7, 0xbc); goto l_0x1018_45e7; /* jmp 0x101845e7 */
        l_0x1018_452b:
            ii(0x1018_452b, 6); cmp(edi, 0x150);                        /* cmp edi, 0x150 */
            ii(0x1018_4531, 2); if(jnz(0x1018_4555, 0x22)) goto l_0x1018_4555; /* jnz 0x10184555 */
            ii(0x1018_4533, 4); mov(edi, memd[ss, esp + 0x40]);         /* mov edi, [esp+0x40] */
        l_0x1018_4537:
            ii(0x1018_4537, 2); cmp(esi, edi);                          /* cmp esi, edi */
            ii(0x1018_4539, 2); if(jge(0x1018_4548, 0xd)) goto l_0x1018_4548; /* jge 0x10184548 */
            ii(0x1018_453b, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x1018_453e, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1018_4541, 2); mov(bh, memb[ds, edx]);                 /* mov bh, [edx] */
            ii(0x1018_4543, 1); inc(esi);                               /* inc esi */
            ii(0x1018_4544, 2); test(bh, bh);                           /* test bh, bh */
            ii(0x1018_4546, 2); if(jz(0x1018_4537, -0x11)) goto l_0x1018_4537; /* jz 0x10184537 */
        l_0x1018_4548:
            ii(0x1018_4548, 8); mov(memd[ss, esp + 0x3c], 0xffff_fffd); /* mov dword [esp+0x3c], 0xfffffffd */
            ii(0x1018_4550, 5); jmp(0x1018_45e7, 0x92); goto l_0x1018_45e7; /* jmp 0x101845e7 */
        l_0x1018_4555:
            ii(0x1018_4555, 4); mov(eax, memd[ss, esp + 0x10]);         /* mov eax, [esp+0x10] */
            ii(0x1018_4559, 4); cmp(eax, memd[ss, esp + 0x8]);          /* cmp eax, [esp+0x8] */
            ii(0x1018_455d, 2); if(jnz(0x1018_456d, 0xe)) goto l_0x1018_456d; /* jnz 0x1018456d */
            ii(0x1018_455f, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1018_4563, 4); cmp(eax, memd[ss, esp + 0x4]);          /* cmp eax, [esp+0x4] */
            ii(0x1018_4567, 6); if(jz(0x1018_45e7, 0x7a)) goto l_0x1018_45e7; /* jz 0x101845e7 */
        l_0x1018_456d:
            ii(0x1018_456d, 4); mov(eax, memd[ss, esp + 0x38]);         /* mov eax, [esp+0x38] */
            ii(0x1018_4571, 3); mov(ecx, memd[ds, eax + 0xc]);          /* mov ecx, [eax+0xc] */
            ii(0x1018_4574, 3); mov(ebx, memd[ds, eax + 0x8]);          /* mov ebx, [eax+0x8] */
            ii(0x1018_4577, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x1018_457a, 3); sub(ecx, 0x9);                          /* sub ecx, 0x9 */
            ii(0x1018_457d, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1018_4580, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_4582, 5); call(/* sys */ 0x1016_c1f0, -0x1_8397); /* call 0x1016c1f0 */
            ii(0x1018_4587, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_4589, 2); if(jz(0x1018_45e7, 0x5c)) goto l_0x1018_45e7; /* jz 0x101845e7 */
            ii(0x1018_458b, 4); mov(eax, memd[ss, esp + 0x38]);         /* mov eax, [esp+0x38] */
            ii(0x1018_458f, 4); mov(edx, memd[ss, esp + 0xc]);          /* mov edx, [esp+0xc] */
            ii(0x1018_4593, 3); sub(edx, memd[ds, eax + 0x4]);          /* sub edx, [eax+0x4] */
            ii(0x1018_4596, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1018_459c, 3); sub(edx, 0x8);                          /* sub edx, 0x8 */
            ii(0x1018_459f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_45a1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_45a3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1018_45a6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1018_45a8, 4); mov(ecx, memd[ss, esp + 0x20]);         /* mov ecx, [esp+0x20] */
            ii(0x1018_45ac, 4); mov(memd[ss, esp + 0x3c], eax);         /* mov [esp+0x3c], eax */
            ii(0x1018_45b0, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1018_45b2, 2); if(jz(0x1018_45d7, 0x23)) goto l_0x1018_45d7; /* jz 0x101845d7 */
            ii(0x1018_45b4, 4); mov(esi, memd[ss, esp + 0x2c]);         /* mov esi, [esp+0x2c] */
            ii(0x1018_45b8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_45bb, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1018_45bd, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_45bf, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1018_45c2, 2); if(jz(0x1018_45ca, 0x6)) goto l_0x1018_45ca; /* jz 0x101845ca */
            ii(0x1018_45c4, 4); mov(esi, memd[ss, esp + 0x3c]);         /* mov esi, [esp+0x3c] */
            ii(0x1018_45c8, 2); jmp(0x1018_45cf, 0x5); goto l_0x1018_45cf; /* jmp 0x101845cf */
        l_0x1018_45ca:
            ii(0x1018_45ca, 5); mov(esi, 0xffff_ffff);                  /* mov esi, 0xffffffff */
        l_0x1018_45cf:
            ii(0x1018_45cf, 8); mov(memd[ss, esp + 0x3c], 0xffff_fffd); /* mov dword [esp+0x3c], 0xfffffffd */
        l_0x1018_45d7:
            ii(0x1018_45d7, 4); mov(eax, memd[ss, esp + 0x10]);         /* mov eax, [esp+0x10] */
            ii(0x1018_45db, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1018_45df, 4); mov(eax, memd[ss, esp + 0xc]);          /* mov eax, [esp+0xc] */
            ii(0x1018_45e3, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
        l_0x1018_45e7:
            ii(0x1018_45e7, 5); cmp(memd[ss, esp + 0x3c], -0x3 /* 0xfd */); /* cmp dword [esp+0x3c], 0xfffffffd */
            ii(0x1018_45ec, 2); if(jnz(0x1018_4666, 0x78)) goto l_0x1018_4666; /* jnz 0x10184666 */
            ii(0x1018_45ee, 4); mov(ebx, memd[ss, esp + 0x58]);         /* mov ebx, [esp+0x58] */
            ii(0x1018_45f2, 4); mov(ecx, memd[ss, esp + 0x1c]);         /* mov ecx, [esp+0x1c] */
            ii(0x1018_45f6, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1018_45fb, 1); push(ebx);                              /* push ebx */
            ii(0x1018_45fc, 4); mov(eax, memd[ss, esp + 0x38]);         /* mov eax, [esp+0x38] */
            ii(0x1018_4600, 5); mov(ebx, 0x8);                          /* mov ebx, 0x8 */
            ii(0x1018_4605, 1); push(ecx);                              /* push ecx */
            ii(0x1018_4606, 4); mov(ecx, memd[ss, esp + 0x38]);         /* mov ecx, [esp+0x38] */
            ii(0x1018_460a, 4); mov(edi, memd[ss, esp + 0x5c]);         /* mov edi, [esp+0x5c] */
            ii(0x1018_460e, 5); call(/* sys */ 0x1016_71f0, -0x1_d423); /* call 0x101671f0 */
            ii(0x1018_4613, 1); push(edi);                              /* push edi */
            ii(0x1018_4614, 2); push(0x8);                              /* push 0x8 */
            ii(0x1018_4616, 4); mov(ecx, memd[ss, esp + 0x38]);         /* mov ecx, [esp+0x38] */
            ii(0x1018_461a, 4); mov(ebx, memd[ss, esp + 0x2c]);         /* mov ebx, [esp+0x2c] */
            ii(0x1018_461e, 2); push(0x2);                              /* push 0x2 */
            ii(0x1018_4620, 4); mov(edx, memd[ss, esp + 0x38]);         /* mov edx, [esp+0x38] */
            ii(0x1018_4624, 4); mov(eax, memd[ss, esp + 0x40]);         /* mov eax, [esp+0x40] */
            ii(0x1018_4628, 5); call(/* sys */ 0x1016_6f04, -0x1_d729); /* call 0x10166f04 */
            ii(0x1018_462d, 3); cmp(esi, -0x1 /* 0xff */);              /* cmp esi, 0xffffffff */
            ii(0x1018_4630, 2); if(jz(0x1018_465d, 0x2b)) goto l_0x1018_465d; /* jz 0x1018465d */
            ii(0x1018_4632, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1018_4638, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_463a, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1018_4640, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x1018_4643, 4); mov(ebp, memd[ss, esp + 0x28]);         /* mov ebp, [esp+0x28] */
            ii(0x1018_4647, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1018_464a, 3); imul(eax, ebp);                         /* imul eax, ebp */
            ii(0x1018_464d, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1018_4650, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1018_4652, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_4654, 4); mov(edx, memd[ss, esp + 0x30]);         /* mov edx, [esp+0x30] */
            ii(0x1018_4658, 5); call(/* sys */ 0x1016_af44, -0x1_9719); /* call 0x1016af44 */
        l_0x1018_465d:
            ii(0x1018_465d, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1018_4661, 5); call(Definitions.sys_display_draw_0, -0x1_d1e2); /* call 0x10167484 */
        l_0x1018_4666:
            ii(0x1018_4666, 5); call(/* sys */ 0x1016_b208, -0x1_9463); /* call 0x1016b208 */
            ii(0x1018_466b, 4); mov(memd[ss, esp + 0x3c], eax);         /* mov [esp+0x3c], eax */
            ii(0x1018_466f, 5); jmp(0x1018_4396, -0x2de); goto l_0x1018_4396; /* jmp 0x10184396 */
        l_0x1018_4674:
            ii(0x1018_4674, 4); mov(eax, memd[ss, esp + 0x34]);         /* mov eax, [esp+0x34] */
            ii(0x1018_4678, 4); mov(ebx, memd[ss, esp + 0x5c]);         /* mov ebx, [esp+0x5c] */
            ii(0x1018_467c, 5); call(/* sys */ 0x1016_6990, -0x1_dcf1); /* call 0x10166990 */
            ii(0x1018_4681, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1018_4683, 6); if(jz(0x1018_47a0, 0x117)) goto l_0x1018_47a0; /* jz 0x101847a0 */
            ii(0x1018_4689, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1018_468b, 5); call(/* sys */ 0x1016_7dac, -0x1_c8e4); /* call 0x10167dac */
            ii(0x1018_4690, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x1018_4693, 4); mov(edx, memd[ss, esp + 0x60]);         /* mov edx, [esp+0x60] */
            ii(0x1018_4697, 4); mov(memd[ss, esp + 0x14], eax);         /* mov [esp+0x14], eax */
            ii(0x1018_469b, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1018_46a2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_46a4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_46a7, 3); lea(edx, ebx + eax);                    /* lea edx, [ebx+eax] */
            ii(0x1018_46aa, 3); mov(eax, memd[ds, edx + 0x18]);         /* mov eax, [edx+0x18] */
            ii(0x1018_46ad, 4); mov(memd[ss, esp + 0x8], eax);          /* mov [esp+0x8], eax */
            ii(0x1018_46b1, 3); mov(eax, memd[ds, edx + 0x1c]);         /* mov eax, [edx+0x1c] */
            ii(0x1018_46b4, 4); mov(memd[ss, esp + 0x4], eax);          /* mov [esp+0x4], eax */
            ii(0x1018_46b8, 3); mov(ebx, memd[ds, edx + 0x24]);         /* mov ebx, [edx+0x24] */
            ii(0x1018_46bb, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1018_46bd, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_46c1, 4); mov(ecx, memd[ss, esp + 0x8]);          /* mov ecx, [esp+0x8] */
            ii(0x1018_46c5, 3); mov(edi, memd[ds, edx + 0x20]);         /* mov edi, [edx+0x20] */
            ii(0x1018_46c8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_46ca, 2); sub(edi, ecx);                          /* sub edi, ecx */
            ii(0x1018_46cc, 5); call(/* sys */ 0x1016_7e3c, -0x1_c895); /* call 0x10167e3c */
            ii(0x1018_46d1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_46d3, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_46d7, 1); inc(edi);                               /* inc edi */
            ii(0x1018_46d8, 6); mov(dl, memb[ds, eax + 0x235]);         /* mov dl, [eax+0x235] */
            ii(0x1018_46de, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_46df, 3); test(dl, 0xff);                         /* test dl, 0xff */
            ii(0x1018_46e2, 2); if(jz(0x1018_470f, 0x2b)) goto l_0x1018_470f; /* jz 0x1018470f */
            ii(0x1018_46e4, 6); mov(eax, memd[ds, eax + 0x234]);        /* mov eax, [eax+0x234] */
            ii(0x1018_46ea, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_46ef, 7); mov(eax, memd[ds, eax * 4 + 0x101b_d9bc]); /* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1018_46f6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_46f8, 6); mov(dl, memb[ds, eax + 0x1020_0520]);   /* mov dl, [eax+0x10200520] */
            ii(0x1018_46fe, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_4702, 6); mov(eax, memd[ds, eax + 0x234]);        /* mov eax, [eax+0x234] */
            ii(0x1018_4708, 3); xor(ax, ax);                            /* xor ax, ax */
            ii(0x1018_470b, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1018_470d, 2); jmp(0x1018_4715, 0x6); goto l_0x1018_4715; /* jmp 0x10184715 */
        l_0x1018_470f:
            ii(0x1018_470f, 6); mov(eax, memd[ds, eax + 0x234]);        /* mov eax, [eax+0x234] */
        l_0x1018_4715:
            ii(0x1018_4715, 4); mov(memd[ss, esp + 0x10], eax);         /* mov [esp+0x10], eax */
            ii(0x1018_4719, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_471d, 7); test(memb[ds, eax + 0x239], 0xff);      /* test byte [eax+0x239], 0xff */
            ii(0x1018_4724, 2); if(jz(0x1018_4754, 0x2e)) goto l_0x1018_4754; /* jz 0x10184754 */
            ii(0x1018_4726, 6); mov(eax, memd[ds, eax + 0x238]);        /* mov eax, [eax+0x238] */
            ii(0x1018_472c, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_4731, 7); mov(eax, memd[ds, eax * 4 + 0x101b_d9bc]); /* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1018_4738, 6); mov(al, memb[ds, eax + 0x1020_0520]);   /* mov al, [eax+0x10200520] */
            ii(0x1018_473e, 4); mov(edx, memd[ss, esp + 0x5c]);         /* mov edx, [esp+0x5c] */
            ii(0x1018_4742, 6); mov(edx, memd[ds, edx + 0x238]);        /* mov edx, [edx+0x238] */
            ii(0x1018_4748, 3); xor(dx, dx);                            /* xor dx, dx */
            ii(0x1018_474b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_4750, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1018_4752, 2); jmp(0x1018_475a, 0x6); goto l_0x1018_475a; /* jmp 0x1018475a */
        l_0x1018_4754:
            ii(0x1018_4754, 6); mov(eax, memd[ds, eax + 0x238]);        /* mov eax, [eax+0x238] */
        l_0x1018_475a:
            ii(0x1018_475a, 4); mov(edx, memd[ss, esp + 0x14]);         /* mov edx, [esp+0x14] */
            ii(0x1018_475e, 4); mov(memd[ss, esp + 0xc], eax);          /* mov [esp+0xc], eax */
            ii(0x1018_4762, 1); push(eax);                              /* push eax */
            ii(0x1018_4763, 4); add(edx, memd[ss, esp + 0xc]);          /* add edx, [esp+0xc] */
            ii(0x1018_4767, 4); mov(eax, memd[ss, esp + 0x8]);          /* mov eax, [esp+0x8] */
            ii(0x1018_476b, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1018_476e, 4); mov(ebp, memd[ss, esp + 0x14]);         /* mov ebp, [esp+0x14] */
            ii(0x1018_4772, 1); push(ebp);                              /* push ebp */
            ii(0x1018_4773, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_4775, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1018_4777, 5); call(/* sys */ 0x1016_af8c, -0x1_97f0); /* call 0x1016af8c */
            ii(0x1018_477c, 4); mov(edx, memd[ss, esp + 0x60]);         /* mov edx, [esp+0x60] */
            ii(0x1018_4780, 7); lea(eax, edx * 8 + 0);                  /* lea eax, [edx*8] */
            ii(0x1018_4787, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_4789, 4); mov(edx, memd[ss, esp + 0x5c]);         /* mov edx, [esp+0x5c] */
            ii(0x1018_478d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1018_4790, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x1018_4793, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_4795, 4); mov(eax, memd[ss, esp + 0x5c]);         /* mov eax, [esp+0x5c] */
            ii(0x1018_4799, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1018_479b, 5); call(Definitions.sys_display_draw_1, -0x1_d2f8); /* call 0x101674a8 */
        l_0x1018_47a0:
            ii(0x1018_47a0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_47a2, 3); add(esp, 0x44);                         /* add esp, 0x44 */
            ii(0x1018_47a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_47a6, 1); pop(edi);                               /* pop edi */
            ii(0x1018_47a7, 1); pop(esi);                               /* pop esi */
            ii(0x1018_47a8, 3); ret(0x10);                              /* ret 0x10 */
        }
    }
}
